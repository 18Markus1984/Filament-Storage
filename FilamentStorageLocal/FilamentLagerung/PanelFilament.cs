using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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
        public CheckBox keller;
        public Button weitereEinstellungen;
        public Button löschen;

        public Form1 form;
        public Filament filament;
        public FlowLayoutPanel flow;

        public PanelFilament(Filament filament,Form1 form)
        {
            this.filament = filament;
            this.form = form;

            this.Width = form.Lager.Width - 8;
            this.Height = 73;
            this.TabIndex = 10;
            this.ColumnCount = 9;
            this.RowCount = 1;
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69));

            

            marke = new Label
            {
                Text = filament.marke,
            };
            
            var margin = marke.Margin;
            margin.Top = 23;
            marke.Margin = margin;

            art = new Label
            {
                Text = filament.art,
                Margin = margin
            };

            durchmesser = new Label
            {
                Text = filament.durchmesser + " mm",
                Margin = margin
            };

            farbe = new Label
            {
                Text = filament.farbe,
                Margin = margin
            };
            farbe.ForeColor = filament.color;

            geoeffnet = new NumericUpDown
            {
                Minimum = 0,
                Maximum = 1000,
                Value = filament.geöffnet,
                Margin = margin,
                ReadOnly = true 
            };
            geoeffnet.ValueChanged += ValueChanged;

            menge = new NumericUpDown
            {
                Minimum = 1,
                Maximum = 1000,
                Value = filament.meneg,
                Margin = margin,
                ReadOnly = true    
            };

            menge.ValueChanged += ValueChanged;

            keller = new CheckBox
            {
                Checked = filament.keller,
                Text = "Keller",
                Margin = margin
            };

            keller.CheckedChanged += ValueChanged;

            weitereEinstellungen = new Button
            {
                BackgroundImage = Properties.Resources.icons8_hinzufügen_96,
                BackgroundImageLayout = ImageLayout.Stretch,
                Height = 65,
                Width = 65
                
            };
            weitereEinstellungen.Click += WeitereEinstellungen;

            löschen = new Button()
            {
                BackgroundImage = Properties.Resources.delete_round_button,
                BackgroundImageLayout = ImageLayout.Stretch,
                Height = 65,
                Width = 65
            };
            löschen.Click += WirklichLoeschen;

            this.Controls.Add(marke);
            this.Controls.Add(art);
            this.Controls.Add(durchmesser);
            this.Controls.Add(farbe);
            this.Controls.Add(geoeffnet);
            this.Controls.Add(menge);
            this.Controls.Add(keller);
            this.Controls.Add(weitereEinstellungen);
            this.Controls.Add(löschen);

        }

        public void WeitereEinstellungen(object sender, EventArgs e)
        {
            Bearbeitung bearbeitung = new Bearbeitung(filament,form);
            bearbeitung.Show();
        }

        public void WirklichLoeschen(object sender, EventArgs e)
        {
            string message = "Willst du das Filament wirklich löschen?";
            string title = "Filament löschen";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                
            }
            else
            {
                form.Remove(this);
            }
        }

        public void ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(menge.Value) >= Convert.ToInt16(geoeffnet.Value))
            {
                filament.keller = keller.Checked;
                filament.meneg = Convert.ToInt16(menge.Value);
                filament.geöffnet = Convert.ToInt16(geoeffnet.Value);

                form.RefreshValueChanged();
            }
            else
            {
                MessageBox.Show("Du willst mehr geöffnete Spulen eingetragen als du insgesamt hast. \nWiederhole die Grundschule nochmal, dann kannst du es nochmal versuchen.","Geh in die 1. Klasse",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                geoeffnet.Value = Convert.ToInt16(geoeffnet.Value) - 1;
            }
            
        }
    }
}
