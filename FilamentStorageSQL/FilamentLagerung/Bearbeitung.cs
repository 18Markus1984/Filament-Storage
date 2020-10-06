using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;



namespace FilamentLagerung
{
    public partial class Bearbeitung : Form
    {
        public System.Data.DataRow filament;
        public Dashboard form;
        public DataSet ds;

        List<string> marken = new List<string>();       //Alle Listen werden erstellt, damit der User aus bis jetzt allen exsistierenden Filamenten wählen kann
        List<string> arten = new List<string>();
        List<float> gewichte = new List<float>();
        List<int> temperaturenE = new List<int>();
        List<int> temperaturenB = new List<int>();
        List<decimal> preise = new List<decimal>();


        public Bearbeitung(System.Data.DataRow filament,DataSet ds,Dashboard form)      //Konstruktor der Form
        {
            this.filament = filament;
            this.form = form;
            this.ds = ds;
            InitializeComponent();

            for (int i = 0; i < form.arten.ds.Tables[0].Rows.Count; i++)        //Alle Arten werden aus dem Dataset Arten herausgezogen
            {
                arten.Add(form.arten.ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }

            for (int i = 0; i < form.marken.ds.Tables[0].Rows.Count; i++)       //Alle Marken werden aus dem Dataset Marken herausgezogen
            {
                marken.Add(form.marken.ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)               //Die restlichen Werte werden nun aus der Filament Dataset herausgezogen
            {   
                if(ds.Tables[0].Rows[i].ItemArray[4] != System.DBNull.Value) 
                    gewichte.Add(Convert.ToInt16(ds.Tables[0].Rows[i].ItemArray[4]));
                if(ds.Tables[0].Rows[i].ItemArray[10] != System.DBNull.Value)
                    temperaturenE.Add(Convert.ToInt16(ds.Tables[0].Rows[i].ItemArray[10]));
                if(ds.Tables[0].Rows[i].ItemArray[9] != System.DBNull.Value)
                    temperaturenB.Add(Convert.ToInt16(ds.Tables[0].Rows[i].ItemArray[9]));
                if (ds.Tables[0].Rows[i].ItemArray[15] != System.DBNull.Value)
                    preise.Add(Convert.ToInt16(ds.Tables[0].Rows[i].ItemArray[15]));
            }

            gewichte = gewichte.Distinct().ToList();        //Da das Gewicht, ExT und BedT doppelt vorkommen können müssen diese Werte distinct
            temperaturenE = temperaturenE.Distinct().ToList();
            temperaturenB = temperaturenB.Distinct().ToList();

            foreach (var item in marken)    //Hier werden die Werte auf die ComboBoxen gesetzt
            {
                marke.Items.Add(item);
            }
            foreach (var item in arten)
            {
                art.Items.Add(item);
            }
            foreach (var item in gewichte)
            {
                gewicht.Items.Add(item);
            }
            foreach (var item in temperaturenE)
            {
                extruder.Items.Add(item);
            }
            foreach (var item in temperaturenB)
            {
                bett.Items.Add(item);
            }
            foreach (var item in preise)
            {
                preis.Items.Add(item);
            }

            durchmesser.Text = filament[1].ToString();      //Die Werte für das jeweilige Filament werden in den Textboxen gespeichert

            marke.Text = filament[13].ToString();
            durchmesser.Text = filament[1].ToString();
            art.Text = filament[14].ToString();
            farbe.Text = filament[2].ToString();
            color.BackColor = Color.FromArgb(Convert.ToInt32(filament[3]));
            colorDialog1.Color = Color.FromArgb(Convert.ToInt32(filament[3]));
            Druckkopf.Text = filament[6].ToString();
            geoeffnet.Text = filament[8].ToString();
            menge.Text = filament[7].ToString();
            lagerung.Text = filament[11].ToString();
            gewicht.Text = filament[4].ToString();
            nummer.Text = filament[5].ToString();
            extruder.Text = filament[10].ToString();
            bett.Text = filament[9].ToString();
            notizen.Text = filament[12].ToString();
            preis.Text = filament[15].ToString();

            if (filament[15] != System.DBNull.Value && gewicht.Text != "")
            {
                geld.Text = Convert.ToDecimal(filament[15].ToString()) / Convert.ToDecimal(filament[4].ToString()) + " €";
            }

            if (File.Exists(@".\Images\" + filament[0] + ".jpg"))   //Die PictureBox bekommt ein Bild, falls ein Bild für diese Zahl exsistiert
            {
                using (Stream stream = File.Open(@".\Images\" + filament[0] + ".jpg",FileMode.Open))        //Über einen Stream wird die Datei ausgelesen, wobei der Stream durch using nach den Geschweiften Klammern direkt wieder aufgelöst wird.
                {
                    pictureBox1.Image = System.Drawing.Image.FromStream(stream);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)      //Ein Bild soll für die Picturebox gesetzt werden und soll dann auch in einem Ordner mit der FilamentIde als Namen gespeichert werden
        {
            OpenFileDialog open = new OpenFileDialog();                         //Ein Image OpenDialog wird geöffnet, damit sich der User das Bild aus seinem Exploarer heraussuchen kann
            open.Filter = "Image Files(*.jpg;*.jepg;*.bmp;)| *.jpg;*.jepg;*.bmp;";      
            if (open.ShowDialog() == DialogResult.OK)
            {
                string imagePath = filament[0] + ".jpg";
                File.Copy(open.FileName, @".\Images\" + imagePath, true);
                using (Stream stream = File.Open(@".\Images\" + filament[0] + ".jpg", FileMode.Open))
                {
                    pictureBox1.Image = System.Drawing.Image.FromStream(stream);
                }
            }
            
        }

        private void menge_KeyPress(object sender, KeyPressEventArgs e)     //Falls der Char keine Zahl ist wird der User informiert und der Wert nicht in die TextBox eingefügt
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                System.Windows.Forms.MessageBox.Show("Bitte geben Sie eine Zahl ein und nicht - " + ch + " - !!!!! Ich danke ihnen für ihre Kooperation.");
            }
        }

        public void ValueChanged(object sender, EventArgs e)        //Falls sich die Werte ändern soll diese funktion aufgerufen werden
        {
            if (marke.Text != "" || art.Text != "" || farbe.Text != "" || farbe.BackColor != art.BackColor || geoeffnet.Text != "" || menge.Text != "" || gewicht.Text != "" || extruder.Text != "" || bett.Text != "") //Falls alle Werte ungleich "" sind wird erst gespeichert 
            {
                form.CheckExsitence(marke.Text, art.Text);
                filament[13] = marke.Text;
                filament[1] = durchmesser.Text;
                filament[14] = art.Text;
                filament[2] = farbe.Text;
                filament[3] = color.BackColor.ToArgb().ToString();
                filament[6] = Druckkopf.Text;
                filament[11] = lagerung.Text;
                filament[5] = nummer.Text;
                filament[12] = notizen.Text;

                if (geoeffnet.Text != "")       //Es wird geschaut ob einer der Werte, die null sein dürfen vielleicht geändert wurden
                {
                    filament[8] = Convert.ToInt16(geoeffnet.Text);
                }
                if (menge.Text != "")
                {
                    filament[7] = Convert.ToInt16(menge.Text);
                }
                if (gewicht.Text != "")
                {
                    filament[4] = Convert.ToInt16(gewicht.Text);
                }
                if (extruder.Text != "")
                {
                    filament[10] = Convert.ToInt16(extruder.Text);
                }
                if (bett.Text != "")
                {
                    filament[9] = Convert.ToInt16(bett.Text);
                }
                if (preis.Text != "")
                {
                    filament[15] = Convert.ToDecimal(preis.Text);
                }
            }
            if (geoeffnet.Text != "" && menge.Text != "")
            {
                if (Convert.ToInt16(geoeffnet.Text) > Convert.ToInt16(menge.Text))      //Das Verhältnis zwischen Geöffnet und insgesamt wird überprüft
                {
                    MessageBox.Show("Du hast mehr geöffnete Spulen eingetragen als du insgesamt hast. \nWiederhole die Grundschule nochmal, dann kannst du es nochmal versuchen.");
                    geoeffnet.Text = Convert.ToInt16(menge.Text) + "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)      //Der ColorDialog wird aufgerufen und der Wert der rauskommt wird auf die PictureBox als Hintrgrundfarbe gespeichert
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                color.BackColor = colorDialog1.Color;
            }
        }

        private void Bearbeitung_FormClosed(object sender, FormClosedEventArgs e)   //Wenn die Form zur weiteren Bearbeitung geschlossen wird werden alle Werte gespeichert
        {
            ValueChanged(sender, e);
            form.Refresh(ds); //alle Werte werden gespeichert
        }

        
    }
}
