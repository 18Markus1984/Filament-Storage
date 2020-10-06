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
        List<string> marken = new List<string>();       //Zwei Listen, damit der User alle bisherigen Marken und Arten als Vorschläge hat
        List<string> arten = new List<string>();

        public Dashboard form;

        public NeuFilament()
        {

        }

        public NeuFilament(Dashboard form)
        {
            this.form = form;
            InitializeComponent();

            for (int i = 0; i < form.marken.ds.Tables[0].Rows.Count; i++)       //Alle Marken werden aus der Filament Tabelle ausgelesen
            {
                marken.Add(form.marken.ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }

            for (int i = 0; i < form.arten.ds.Tables[0].Rows.Count; i++)
            {
                arten.Add(form.arten.ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }

            marken = marken.Distinct().ToList();            //Falls es dopplungen gibt werden diese entfernt
            arten = arten.Distinct().ToList();

            foreach (var item in marken)            //Die ComboBoxen bekommen die Marken und Arten als Items
            {
                marke.Items.Add(item);
            }
            foreach (var item in arten)
            {
                art.Items.Add(item);
            }
        }
        

        private void button5_Click(object sender, EventArgs e)      //Beim drücken auf den Farb-Knopf wird ein Color-Dialog geöffnet und die ausgewählte Farbe wird gespeichert. Die Standart Farbe ist schwarz
        {
            if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                farbe.ForeColor = colorDialog1.Color;       //Die Farbe des ColorDialog wird auf als Farbe für den Farbennamen verwendet
            }
        }

        private void button2_Click(object sender, EventArgs e)      //Kleine Instruktionen falls nötig
        {
            MessageBox.Show("Du kannst in diesem Menü neue Filamente hinzufügen. Hier gibt es nur die nötigsten Einstellungen," +
                " die für eine Filament-Spule erfüllt sein sollten. Weitere Einstellungen kannst du im Nachhinein noch im erweiterten Menü " +
                "eintragen. \n" +
                "Falls du dir nicht sicher bist welche Werte alle Ausgefüllt werden müssen hier ein paar Infos:\n\n" +
                "1. Falls du keinen Filament Hersteller kennst gib bitte Unbekannt ein\n\n" +
                "2. Bitte fülle alle rot markierten Felder aus!\n\n" +
                "3. Wenn du Verbsserungen oder Ideen für das Projekt hast dann bitte schreibe mir diese unter 'markusschmidt1984@gmx.de'\n\n" +
                "(PS. Wer liest sich das überhaupt durch?)");
        }

        private void button3_Click(object sender, EventArgs e)  //Speichern
        {
            if (marke.Text != "" && durchmesser.Text != "" && art.Text != "" && farbe.Text != "" && Druckkopf.Text != "" && geoeffnet.Text != "" && menge.Text != "" && Convert.ToInt16(geoeffnet.Text) <= Convert.ToInt16(menge.Text) && lagerung.Text != "")
            {       //Wenn alle nötigen Felder ausgefüllt sind wird das Filament gespeichert
                form.CheckExsitence(marke.Text,art.Text);       //Hier wird überprüft ob die Marke oder die Art shon exsistieren und erst sie gegebenfalls
                DataRow row = form.filament.ds.Tables[0].NewRow();      //Es wird eine neue Reihe erstellt, die dann zu der Tabelle hinzugefügt wird
                row[1] = durchmesser.Text;
                row[2] = farbe.Text;
                row[3] = colorDialog1.Color.ToArgb().ToString();
                row[6] = Druckkopf.Text;
                row[8] = Convert.ToInt16(geoeffnet.Text);
                row[7] = Convert.ToInt16(menge.Text);
                row[11] = lagerung.Text;
                row[13] = marke.Text;
                row[14] = art.Text;

                form.filament.ds.Tables[0].Rows.Add(row);

                form.Refresh(form.filament.ds);
                Reset();        //Die Werte werden für die nächste Eingabe zurück gesetzt
            }
            else if(geoeffnet.Text != "" && menge.Text != "")       //Es wird auch überprüft, ob das Verhältnis von geoeffneten und der insgesamt Anzahl an Spulen stimmt
            {
                if (Convert.ToInt16(geoeffnet.Text) > Convert.ToInt16(menge.Text))
                {
                    MessageBox.Show("Du hast mehr geöffnete Spulen eingetragen als du insgesamt hast. \nWiederhole die Grundschule nochmal, dann kannst du es nochmal versuchen.");
                }
            }
            else
            {           //Alle Felder die nicht ausgefüllt sind werden rot makiert
                if (marke.Text == "")
                {
                    labelmarke.ForeColor = Color.Red;
                }
                else
                {
                    labelmarke.ForeColor = Color.White;
                }
                if (durchmesser.Text == "")
                {
                    labeldurchmesser.ForeColor = Color.Red;
                }
                else
                {
                    labelmarke.ForeColor = Color.White;
                }
                if (art.Text == "")
                {
                    label3.ForeColor = Color.Red;
                }
                else
                {
                    labelmarke.ForeColor = Color.White;
                }
                if (farbe.Text == "")
                {
                    label4.ForeColor = Color.Red;
                }
                else
                {
                    labelmarke.ForeColor = Color.White;
                }
                if (Druckkopf.Text == "")
                {
                    label5.ForeColor = Color.Red;
                }
                else
                {
                    labelmarke.ForeColor = Color.White;
                }
                if (geoeffnet.Text == "")
                {
                    label6.ForeColor = Color.Red;
                }
                else
                {
                    labelmarke.ForeColor = Color.White;
                }
                if (menge.Text == "")
                {
                    label7.ForeColor = Color.Red;
                }
                else
                {
                    labelmarke.ForeColor = Color.White;
                }
                if (lagerung.Text == "")
                {
                    label8.ForeColor = Color.Red;
                }
                else
                {
                    labelmarke.ForeColor = Color.White;
                }
            }
        }

        private void menge_KeyPress(object sender, KeyPressEventArgs e)     //Es geschaut, dass der eingebene Char eine Zahl ist
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                System.Windows.Forms.MessageBox.Show("Bitte geben Sie eine Zahl ein und nicht - " + ch + " - !!!!! Ich danke ihnen für ihre Kooperation.");
            }
        }

        public void Reset()
        {
            marke.Text = "";
            durchmesser.Text = "";
            art.Text = "";
            farbe.Text = "";
            Druckkopf.Text = "";
            geoeffnet.Text = "";
            menge.Text = "";
            lagerung.Text = "";
            colorDialog1.Color = Color.Black;
        }
    }
}
