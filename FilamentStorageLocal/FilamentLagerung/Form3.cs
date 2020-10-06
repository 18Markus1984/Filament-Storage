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
        public Filament filament;
        public Form1 form;

        List<string> marken = new List<string>();
        List<string> arten = new List<string>();
        List<float> gewichte = new List<float>();
        List<int> temperaturenE = new List<int>();
        List<int> temperaturenB = new List<int>();


        public Bearbeitung(Filament filament, Form1 form)
        {
            this.filament = filament;
            this.form = form;
            InitializeComponent();


            foreach (var item in form.filaments)
            {
                marken.Add(item.marke);
                arten.Add(item.art);
                gewichte.Add(item.gewicht);
                temperaturenE.Add(item.extruder);
                temperaturenB.Add(item.druckbett);
            }

            marken = marken.Distinct().ToList();
            arten = arten.Distinct().ToList();
            gewichte = gewichte.Distinct().ToList();
            temperaturenE = temperaturenE.Distinct().ToList();
            temperaturenB = temperaturenB.Distinct().ToList();

            foreach (var item in marken)
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

            marke.Text = filament.marke;
            durchmesser.Text = filament.durchmesser + "";
            art.Text = filament.art;
            farbe.Text = filament.farbe;
            color.BackColor = filament.color;
            colorDialog1.Color = filament.color;
            Druckkopf.Text = filament.druckkopf;
            geoeffnet.Text = filament.geöffnet + "";
            menge.Text = filament.meneg + "";
            keller.Checked = filament.keller;
            gewicht.Text = filament.gewicht + "";
            nummer.Text = filament.materialnummer;
            extruder.Text = filament.extruder + "";
            bett.Text = filament.druckbett + "";
            notizen.Text = filament.notizen;

            if (File.Exists(@".\Images\" + filament.filamentBild + ".jpg"))
            {
                pictureBox1.Image = Image.FromFile(@".\Images\" + filament.filamentBild + ".jpg");
            }

            //marke.TextChanged += ValueChanged;
            //durchmesser.TextChanged += ValueChanged;
            //art.TextChanged += ValueChanged;
            //farbe.TextChanged += ValueChanged;
            //color.BackColorChanged += ValueChanged;
            //Druckkopf.TextChanged += ValueChanged;
            //geoeffnet.TextChanged += ValueChanged;
            //menge.TextChanged += ValueChanged;
            //keller.CheckedChanged += ValueChanged;
            //gewicht.TextChanged += ValueChanged;
            //nummer.TextChanged += ValueChanged;
            //extruder.TextChanged += ValueChanged;
            //bett.TextChanged += ValueChanged;
            //notizen.TextChanged += ValueChanged;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image img;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jepg;*.bmp;)| *.jpg;*.jepg;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                img = Image.FromFile(open.FileName);
                string image = filament.filamentBild + ".jpg";

                if (File.Exists(@".\Images\" + image))
                {
                    pictureBox1.Dispose();
                }
                System.IO.File.Copy(open.FileName, @".\Images\" + image, true);
            }
        }

        private void menge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                System.Windows.Forms.MessageBox.Show("Bitte geben Sie eine Zahl ein und nicht - " + ch + " - !!!!! Ich danke ihnen für ihre Kooperation.");
            }
        }

        //public void ValueChanged(object sender, EventArgs e)
        //{
        //    if (marke.Text != "" || art.Text != "" || farbe.Text != "" || farbe.BackColor != art.BackColor || geoeffnet.Text != "" || menge.Text != "" || gewicht.Text != "" || extruder.Text != "" || bett.Text != "")
        //    {
        //        filament.marke = marke.Text;
        //        filament.durchmesser = Convert.ToDouble(durchmesser.Text);
        //        filament.art = art.Text;
        //        filament.farbe = farbe.Text;
        //        filament.color = color.BackColor;
        //        filament.druckkopf = Druckkopf.Text;
        //        filament.keller = keller.Checked;
        //        filament.materialnummer = nummer.Text;
        //        filament.notizen = notizen.Text;

        //        if (geoeffnet.Text != "" && menge.Text != "" && gewicht.Text != "" && extruder.Text != "" && bett.Text != "")
        //        {
        //            filament.geöffnet = Convert.ToInt16(geoeffnet.Text);
        //            filament.meneg = Convert.ToInt16(menge.Text);
        //            filament.gewicht = Convert.ToInt16(gewicht.Text);
        //            filament.extruder = Convert.ToInt16(extruder.Text);
        //            filament.druckbett = Convert.ToInt16(bett.Text);
        //        }

        //        form.Refresh();
        //    }
        //    if (geoeffnet.Text != "" && menge.Text != "")
        //    {
        //        if (Convert.ToInt16(geoeffnet.Text) > Convert.ToInt16(menge.Text))
        //        {
        //            MessageBox.Show("Du hast mehr geöffnete Spulen eingetragen als du insgesamt hast. \nWiederhole die Grundschule nochmal, dann kannst du es nochmal versuchen.");
        //            geoeffnet.Text = Convert.ToInt16(menge.Text) + "";
        //        }
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                color.BackColor = colorDialog1.Color;
            }
        }

        private void Bearbeitung_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (marke.Text != "" || art.Text != "" || farbe.Text != "" || farbe.BackColor != art.BackColor || geoeffnet.Text != "" || menge.Text != "" || gewicht.Text != "" || extruder.Text != "" || bett.Text != "")
            {
                filament.marke = marke.Text;
                filament.durchmesser = Convert.ToDouble(durchmesser.Text);
                filament.art = art.Text;
                filament.farbe = farbe.Text;
                filament.color = color.BackColor;
                filament.druckkopf = Druckkopf.Text;
                filament.keller = keller.Checked;
                filament.materialnummer = nummer.Text;
                filament.notizen = notizen.Text;

                if (geoeffnet.Text != "" && menge.Text != "" && gewicht.Text != "" && extruder.Text != "" && bett.Text != "")
                {
                    filament.geöffnet = Convert.ToInt16(geoeffnet.Text);
                    filament.meneg = Convert.ToInt16(menge.Text);
                    filament.gewicht = Convert.ToInt16(gewicht.Text);
                    filament.extruder = Convert.ToInt16(extruder.Text);
                    filament.druckbett = Convert.ToInt16(bett.Text);
                }

                form.Refresh();
            }
            if (geoeffnet.Text != "" && menge.Text != "")
            {
                if (Convert.ToInt16(geoeffnet.Text) > Convert.ToInt16(menge.Text))
                {
                    MessageBox.Show("Du hast mehr geöffnete Spulen eingetragen als du insgesamt hast. \nWiederhole die Grundschule nochmal, dann kannst du es nochmal versuchen.");
                    geoeffnet.Text = Convert.ToInt16(menge.Text) + "";
                    e.Cancel = (e.CloseReason == CloseReason.UserClosing);
                    this.BringToFront();
                }
            }
        }
    
    }
}
