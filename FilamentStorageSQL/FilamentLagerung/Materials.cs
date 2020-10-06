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
    public partial class Materials : Form
    {
        public Home form;
        public Dashboard dashboard;

        public Materials()
        {

        }

        public Materials(Home form)
        {
            this.form = form;
            this.dashboard = form.dashboard;
            InitializeComponent();       

            dataGridView1.DataSource = form.dashboard.arten.ds.Tables[0];       //Das dataGriedView wird mit Daten befüllt
            for (int i = 0; i < dashboard.arten.ds.Tables[0].Rows.Count; i++)           //Für jede Reihe werden nocheinmal speziele Werte bestimmt
            {
                dataGridView1.Rows[i].Cells[1].Value = DurchschnittsPreis(dashboard.arten.ds.Tables[0].Rows[i].ItemArray[0].ToString());    //Der durschnittliche Preis für die Filament Art
                dataGridView1.Rows[i].Cells[2].Value = Zaehlen(dashboard.arten.ds.Tables[0].Rows[i].ItemArray[0].ToString());       //Wie viele Spulen man von dem Material hat
            }
        }

        private void Materials_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.dashboard.arten.SaveData();    //Die Daten werden beim schließen gespeichert
            form.dashboard.filament.ds = form.dashboard.filament.ReadData("filament");      //Die filament Tabelle muss ja auch geupdatet werden, falls der user Marke oder Art verändert hat 
        }

        public decimal DurchschnittsPreis(string material)      //Alle Filamente werden durchgegangen. Der Preis derer der selber Art wird in einer Liste gespeichert, zusammengerechnet und durch die Anzahl geteilt.
        {
            List<Decimal> preise = new List<decimal>();
            Decimal preis = 0;
            for (int i = 0; i < dashboard.filament.ds.Tables[0].Rows.Count; i++)
            {
                if (dashboard.filament.ds.Tables[0].Rows[i].ItemArray[14].ToString() == material && dashboard.filament.ds.Tables[0].Rows[i].ItemArray[15] != System.DBNull.Value)
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

        public int Zaehlen(string ArtName)  //Es werden alle Filamente durchgegangen und gezählt wie oft es die Art gibt
        {
            int zaehler = 0;
            for (int i = 0; i < dashboard.filament.ds.Tables[0].Rows.Count; i++)
            {
                if (dashboard.filament.ds.Tables[0].Rows[i].ItemArray[14].ToString() == ArtName)    
                {
                    zaehler++;
                }
            }

            return zaehler;
        }
    }
}
