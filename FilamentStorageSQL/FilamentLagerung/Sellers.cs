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
    public partial class Sellers : Form
    {
        public Home form;
        public Dashboard dashboard;

        public Sellers()
        {

        }

        public Sellers(Home form, DataSet verkaufer)
        {
            this.form = form;
            this.dashboard = form.dashboard;
            InitializeComponent();

            dataGridView1.DataSource = verkaufer.Tables[0];      //Das dataGriedView wird mit Daten befüllt
            dataGridView1.Refresh();
            for (int i = 0; i < verkaufer.Tables[0].Rows.Count; i++)        //Für jede Reihe werden nocheinmal speziele Werte bestimmt
            {
                dataGridView1.Rows[i].Cells[2].Value = Zaehlen(verkaufer.Tables[0].Rows[i].ItemArray[0].ToString());        //Wie viele Spulen man von dem Material hat
                dataGridView1.Rows[i].Cells[1].Value = DurchschnittsPreis(verkaufer.Tables[0].Rows[i].ItemArray[0].ToString());     //Der durschnittliche Preis für den Filamentpreis des Verkäufers
            }
        }

        private void Sellers_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.dashboard.marken.SaveData();   //Die Daten werden beim schließen gespeichert
            form.dashboard.filament.ds = form.dashboard.filament.ReadData("filament");      //Die filament Tabelle muss ja auch geupdatet werden, falls der user Marke oder Art verändert hat 
        }

        public decimal DurchschnittsPreis(string firmenName)    //Alle Filamente werden durchgegangen. Der Preis derer der selber Art wird in einer Liste gespeichert, zusammengerechnet und durch die Anzahl geteilt.
        {
            List<Decimal> preise = new List<decimal>();
            Decimal preis = 0;
            for (int i = 0; i < dashboard.filament.ds.Tables[0].Rows.Count; i++)
            {
                if (dashboard.filament.ds.Tables[0].Rows[i].ItemArray[13].ToString() == firmenName && dashboard.filament.ds.Tables[0].Rows[i].ItemArray[15] != System.DBNull.Value)
                {
                    preise.Add(Convert.ToDecimal(dashboard.filament.ds.Tables[0].Rows[i].ItemArray[15]));
                }
            }
            foreach (var item in preise)
            {
                preis = preis + item;
            }

            if (preis != 0 && preise.Count != 0)
            {
                return preis / preise.Count;
            }
            return 0;
        }

        public int Zaehlen(string firmenName)   //Es werden alle Filamente durchgegangen und gezählt wie oft es den Hersteller gibt
        {
            int zaehler = 0;
            for (int i = 0; i < dashboard.filament.ds.Tables[0].Rows.Count; i++)
            {
                if (dashboard.filament.ds.Tables[0].Rows[i].ItemArray[13].ToString() == firmenName)
                {
                    zaehler++;
                }
            }

            return zaehler;
        }
    }
}
