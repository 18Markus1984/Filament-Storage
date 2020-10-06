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
    public partial class Suche : Form
    {
        public Dashboard form;

        public Suche()
        {

        }

        public Suche(Dashboard form)
        {
            this.form = form;
            InitializeComponent();
            for (int i = 0; i < form.filament.ds.Tables[0].Columns.Count; i++) //Alle Werte in der ComboBox werden auf die Namen der Spalten vom Filament Dataset gesetzt 
            {
                comboBox1.Items.Add(form.filament.ds.Tables[0].Columns[i].ColumnName);
            }

            dataGridView1.DataSource = form.filament.ds.Tables[0];  //Das DataGriedview bekommt das Fiament DataSet zugewießen
        }

        private void button1_Click(object sender, EventArgs e)  //Suchfunktion
        {
            if (comboBox1.Text != "")   //Die Funktion wird nur ausgeführt, wenn die TextBox nicht "" ist
            {
                int test = 0;
                decimal tst = 0;
                SQLConnection suche = new SQLConnection("filament");
                if (int.TryParse(textBox1.Text, out test))  //Hier wird getestet, ob der Inhalt in der TextBox ein Int ist
                {
                    suche.ds = suche.ReadData("filament WHERE " + comboBox1.Text + " = '" + Convert.ToInt16(textBox1.Text) + "'");
                }
                else if (decimal.TryParse(textBox1.Text, out tst))  //Hier wird getestet, ob der Inhalt in der TextBox eine deciml Zahl ist
                {
                    suche.ds = suche.ReadData("filament WHERE " + comboBox1.Text + " = '" + Convert.ToDecimal(textBox1.Text) + "'");
                }
                else //Jetzt gehen wir davon aus, dass es ein string ist
                {
                    suche.ds = suche.ReadData("filament WHERE " + comboBox1.Text + " = '" + textBox1.Text+"'");
                }
                dataGridView1.DataSource = suche.ds.Tables[0];  //Diese Werte werden dann in das DataGriedView gespeichert
            }
        }

        private void Suche_SizeChanged(object sender, EventArgs e)  //Wenn sich die Größe der From verändert passt sich das DataGridView dementsprechend an
        {
            dataGridView1.Height = this.Size.Height - 92;
            dataGridView1.Width = this.Size.Width - 22;
        }

        private void suchenToolStripMenuItem_Click(object sender, EventArgs e)   //Die Such-form wird geschlossen und bevor die Form geschlossen wird, werden alle Daten im FlowLayoutPanle geupdatet 
        {
            form.Refresh(form.filament.ds);
            this.Close();
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)   //Es gibt ein paar hilfreiche Informationen zur Benutzung der Suche
        {
            MessageBox.Show("Die Suche ist dafür da, dass du eine bessere Übersicht über deine Filamente hast.\n\n" +
                "1. Du kannst hier keinen Wert verändern.\n\n" +
                "2. Wenn du auf eine Reihe klickst werden die Erweiterten-Einstellungen zu diesem Filament angezeigt.\n\n" +
                "3. Mit der DropDown Liste kannst du einstellen nach was du suchen möchtest und in der TextBo rechts " +
                "daneben kannst du den Wert eintragen nach dem Gesucht wird z.B. würde ich gerne Nach allen Filamenten " +
                "suchen die von Ultimaker sind ");
        }

        private void button2_Click(object sender, EventArgs e)      //Resets the TextBox für die Such und die Daten im DataGridview
        {
            dataGridView1.DataSource = form.filament.ds.Tables[0];
            textBox1.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)    //Falls man auf eine Zelle in einer Reihe klickt wird die Form für die Weiterebearbeitung für das jeweilige Filament geöffnet 
        {
            if (e.RowIndex != dataGridView1.Rows.Count - 1 && e.RowIndex != -1)
            {
                Bearbeitung bearbeitung = new Bearbeitung(form.filament.ds.Tables[0].Rows[e.RowIndex],form.filament.ds, form);
                bearbeitung.Show();
            }
        }

        private void neuesFilament_Click(object sender, EventArgs e)       //Öffnet eine weitere Form zur Erstellung eines neuen Filaments
        {
            NeuFilament neuFilament = new NeuFilament(form);
            neuFilament.Show();
        }
    }
}
