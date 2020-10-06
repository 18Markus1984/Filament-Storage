using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilamentLagerung
{
    public partial class NeuFilament : Form
    {
        List<string> marken = new List<string>();
        List<string> arten = new List<string>();

        public Form1 form;
        public NeuFilament(Form1 form)
        {
            this.form = form;
            InitializeComponent();

            foreach (var item in form.filaments)
            {
                marken.Add(item.marke);
                arten.Add(item.art);
            }

            marken = marken.Distinct().ToList();
            arten = arten.Distinct().ToList();

            foreach (var item in marken)
            {
                marke.Items.Add(item);
            }
            foreach (var item in arten)
            {
                art.Items.Add(item);
            }
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                farbe.ForeColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Du kannst in diesem Menü neue Filament Sorten hinzufügen. Hier gibt es nur die nötigsten Einstellungen," +
                " die für eine Filament-Spule erfüllt sein sollten. Weitere Einstellungen kannst du im Nachhinein noch eintragen. \n" +
                "Falls du dir nicht sicher bist welche Werte alle Ausgefüllt werden müssen hier ein paar Infos:\n\n" +
                "1. Falls du keinen Filament Hersteller kennst gib bitte Unbekannt ein\n" +
                "2. Bitte fülle alle rot markierten Felder aus!\n" +
                "3. Wenn du Verbsserungen oder Ideen für das Projekt hast dann bitte schreibe mir diese unter 'markusschmidt1984@gmx.de'\n\n" +
                "(PS. Wer liest sich das überhaupt durch?)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //speichern.Text = durchmesser.Text;
            if (marke.Text != "" && durchmesser.Text != "" && art.Text != "" && farbe.Text != "" && Druckkopf.Text != "" && geoeffnet.Text != "" && menge.Text != "" && Convert.ToInt16(geoeffnet.Text) <= Convert.ToInt16(menge.Text))
            {
                Filament filament = new Filament(marke.Text, Convert.ToDouble(durchmesser.Text), art.Text, farbe.Text, colorDialog1.Color, Druckkopf.Text, Convert.ToInt16(geoeffnet.Text), Convert.ToInt16(menge.Text), keller.Checked, form.filaments.Count);
                form.SpeichernvonDaten(filament);
                this.Close();
            }
            else if(geoeffnet.Text != "" && menge.Text != "")
            {
                if (Convert.ToInt16(geoeffnet.Text) > Convert.ToInt16(menge.Text))
                {
                    MessageBox.Show("Du hast mehr geöffnete Spulen eingetragen als du insgesamt hast. \nWiederhole die Grundschule nochmal, dann kannst du es nochmal versuchen.");
                }
            }
            else
            {
                if (marke.Text == "")
                {
                    label1.ForeColor = Color.Red;
                }
                else
                {
                    label1.ForeColor = Color.Black;
                }
                if (durchmesser.Text == "")
                {
                    label2.ForeColor = Color.Red;
                }
                else
                {
                    label2.ForeColor = Color.Black;
                }
                if (art.Text == "")
                {
                    label3.ForeColor = Color.Red;
                }
                else
                {
                    label3.ForeColor = Color.Black;
                }
                if (farbe.Text == "" || farbe.BackColor == art.BackColor)
                {
                    label4.ForeColor = Color.Red;
                }
                else
                {
                    label4.ForeColor = Color.Black;
                }
                if (Druckkopf.Text == "")
                {
                    label5.ForeColor = Color.Red;
                }
                else
                {
                    label5.ForeColor = Color.Black;
                }
                if (geoeffnet.Text == "")
                {
                    label6.ForeColor = Color.Red;
                }
                else
                {
                    label6.ForeColor = Color.Black;
                }
                if (menge.Text == "")
                {
                    label7.ForeColor = Color.Red;
                }
                else
                {
                    label7.ForeColor = Color.Black;
                }
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

        
    }
}
