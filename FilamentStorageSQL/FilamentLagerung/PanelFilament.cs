using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace FilamentLagerung
{
    public class PanelFilament : TableLayoutPanel
    {
        public Label marke;
        public Label art;
        public Label durchmesser;
        public Label farbe;
        public NumericUpDown geoeffnet;
        public NumericUpDown menge;
        public Label keller;
        public Button weitereEinstellungen;
        public Button löschen;

        public Dashboard form;
        public System.Data.DataRow filament;
        public DataSet ds;
        public FlowLayoutPanel flow;

        public PanelFilament(System.Data.DataRow filament,DataSet ds,Dashboard form)        //Konstruktor des Filaments für die Startseite
        {
            this.ForeColor = Color.White;
            this.form = form;
            this.filament = filament;
            this.ds = ds;

            this.Width = form.Lager.Width - 25;     //Die Größe wird responsive auf die Größe des Lagers bzw. des FlowLayoutPanels angepasst
            this.Height = 73;
            this.TabIndex = 10;                 
            this.ColumnCount = 9;                   
            this.RowCount = 1;
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94));      //Die Größen der einzelnen Zellen wird definiert
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70));

            marke = new Label               //Alle Objekte werden mit den Informationen aus einer DataRow befüllt
            {
                Text = filament[13].ToString(),
            };
            
            var margin = marke.Margin;      //Hier wird ein stanard Margin erstellt, der bei allen Elementen verwendet wird. 
            margin.Top = 23;
            marke.Margin = margin;

            art = new Label
            {
                Text = filament[14].ToString(),
                Margin = margin
            };

            durchmesser = new Label
            {
                Text = filament[1] + " mm",
                Margin = margin
            };

            farbe = new Label
            {
                Text = filament[2].ToString(),
                Margin = margin
            };    
            farbe.ForeColor = Color.FromArgb(Convert.ToInt32(filament[3]));     //Der Farbenname wird in der Farbe angezeigt die vorher beim erstellen gespeichert wurde

            geoeffnet = new NumericUpDown
            {
                Minimum = 0,
                Maximum = 1000, //Die Maximale Anzahl für die geöffneten Filamente wird auf 1000 gesetzt
                Value = Convert.ToInt16(filament[8]),
                Margin = margin,
                ReadOnly = true 
            };
            geoeffnet.ValueChanged += ValueChanged;     //Überprüfen, dass das Verhältnis stimmt

            menge = new NumericUpDown
            {
                Minimum = 1,    //Man kann muss ja insgesamt ein Filament haben, damit es exsitieren kann 
                Maximum = 1000, //Die Maximale Anzahl für alle Filamente wird auf 1000 gesetzt
                Value = Convert.ToInt16(filament[7]),
                Margin = margin,
                ReadOnly = true    
            };

            menge.ValueChanged += ValueChanged;         //Überprüfen, dass das Verhältnis stimmt

            keller = new Label
            {
                Text = filament[11].ToString(),
                Margin = margin
            };

            keller.TextChanged += ValueChanged;

            weitereEinstellungen = new Button
            {
                BackgroundImage = Properties.Resources.icons8_hinzufügen_96,
                BackgroundImageLayout = ImageLayout.Stretch,
                FlatStyle = FlatStyle.Flat,
                
                Height = 65,
                Width = 65
                
            };
            weitereEinstellungen.Click += WeitereEinstellungen;
            weitereEinstellungen.FlatAppearance.BorderSize = 0;


            löschen = new Button()
            {
                BackgroundImage = Properties.Resources.delete_round_button,
                BackgroundImageLayout = ImageLayout.Stretch,
                FlatStyle = FlatStyle.Flat,
                Height = 65,
                Width = 65
            };
            löschen.Click += WirklichLoeschen;
            löschen.FlatAppearance.BorderSize = 0;

            this.Controls.Add(marke);           //Alle Objekte werden zum TableLayoutPanle hinzugefügt
            this.Controls.Add(art);
            this.Controls.Add(durchmesser);
            this.Controls.Add(farbe);
            this.Controls.Add(geoeffnet);
            this.Controls.Add(menge);
            this.Controls.Add(keller);
            this.Controls.Add(weitereEinstellungen);
            this.Controls.Add(löschen);

        }

        public void WeitereEinstellungen(object sender, EventArgs e)            //Die erweiterten Einstellungen für das Filament wird geöffnet bzw. Form 3
        {
            Bearbeitung bearbeitung = new Bearbeitung(filament,ds,form);
            bearbeitung.Show();
        }

        public void WirklichLoeschen(object sender, EventArgs e)        //Beim drücken des Löschen Knopfs 
        {
            string message = "Willst du das Filament wirklich löschen?";
            string title = "Filament löschen";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);     //WindowsMessageBox fragt nochmal ob das Fiament wirklich gelöscht werden soll  
            if (result == DialogResult.No)
            {
                
            }
            else
            {
                form.Delete(this);
            }
        }

        public void ValueChanged(object sender, EventArgs e)            //Überprüft, ob das Verhältnis zwischen geöffneten und isgesamten Filamentspulen stimmt und speichert die Werte, die verändert werden können
        {
            if (Convert.ToInt16(menge.Value) >= Convert.ToInt16(geoeffnet.Value))
            {
                filament[11] = keller.Text;
                filament[7] = Convert.ToInt16(menge.Value);
                filament[8] = Convert.ToInt16(geoeffnet.Value);

                form.filament.SaveData();
            }
            else    //Falls das Verhältnis nicht stimmt bekommt der User eine Information und die Anzahl der geöffneten Filamente wird um eins verringert.
            {
                MessageBox.Show("Du willst mehr geöffnete Spulen eingetragen als du insgesamt hast. \nWiederhole die Grundschule nochmal, dann kannst du es nochmal versuchen.","Geh in die 1. Klasse",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                geoeffnet.Value = Convert.ToInt16(geoeffnet.Value) - 1;
            }
            
        }
    }
}
