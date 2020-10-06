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
using MySql.Data.MySqlClient;


namespace FilamentLagerung
{
    public partial class Dashboard : Form
    {
        Home form;
        public SQLConnection filament;      //Die Klassen für die jeweiligen Tabellen
        public SQLConnection arten;
        public SQLConnection marken;

        public Dashboard(Home form)
        {
            InitializeComponent();
            this.form = form;

            filament = new SQLConnection("filament");   //Die VerbindungsKlassen wird Initalisiert
            arten = new SQLConnection("material");
            marken = new SQLConnection("unternehmen");
            Refresh(filament.ds);                       //Das FlowLayoutPanel wird mit den Daten aus Filament beschrieben
        }

        public void CheckExsitence(string marke, string art)        //Schaut, ob das Unternehmen oder das Material schon exsistieren 
        {
            int counterM = 0;
            int counterA = 0;
            for (int i = 0; i < marken.ds.Tables[0].Rows.Count; i++)        //Die Marken-Tabelle wird durchsucht und ein Counter hochgezählt und sollte der Counter 0 sein gibt es diese Marke noch nicht
            {
                if (marke == marken.ds.Tables[0].Rows[i].ItemArray[0] + "")
                {
                    counterM++;
                }
            }
            for (int i = 0; i < arten.ds.Tables[0].Rows.Count; i++)         //Die Arten-Tabelle wird durchsucht und ein Counter hochgezählt und sollte der Counter 0 sein gibt es diese Art noch nicht
            {
                if (art == arten.ds.Tables[0].Rows[i].ItemArray[0] + "")
                {
                    counterA++;
                }
            }
            if (counterA == 0)          //Die Art exsistiert noch nicht und eine neue Row wird erstellt, die dann zum Dataset arten hinzugefügt
            {
                DataRow dataRow1 = arten.ds.Tables[0].NewRow();
                dataRow1[0] = art;
                arten.ds.Tables[0].Rows.Add(dataRow1);
                arten.SaveData();
            }
            if (counterM == 0)          //Gleiche vorgehensweise wie bei den Arten
            {
                DataRow dataRow2 = marken.ds.Tables[0].NewRow();
                dataRow2[0] = marke;
                marken.ds.Tables[0].Rows.Add(dataRow2);
                marken.SaveData();
            }
        }

        public void Delete(PanelFilament panel)     //Die Delete-Funktion, die aus dem TableLayoutPanle aufgerufen wird
        {
            string id = panel.filament[0].ToString();
            if (File.Exists(@".\Images\" + id + ".jpg"))        //Falls ein Bild zu dem Filament exsistert wird es gelöscht
            {
                File.Delete(@".\Images\" + id + ".jpg");
            }

            filament.DeleteData(panel.filament);        //Die Funktion in der SQLConnection Klasse wird aufgerufen um die Daten in der MyAdminPHP Datenbank zu löschen

            this.Controls.Remove(panel);               //Das Panle wird aus dem FlowLayoutPanle entfernt
            Refresh(panel.ds);                          //Das FlowLayoutPanle wird geupdatet
        }

        public void Refresh(DataSet ds)
        {
            filament.SaveData();    //Die Daten werden in der MyAdminPhp Datenbank gespeichert
            if (this != null)
            {
               Lager.Controls.Clear();     //Das FlowLayoutPanel wird geleert
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)   //Das nun leere "Lager" wird wieder mit allen Daten gefüllt
                {
                    Lager.Controls.Add(new PanelFilament(ds.Tables[0].Rows[i], ds, this));
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)       //Wenn sich die Form schließt sollen die Daten gespeichert werden
        {
            filament.SaveData();
        }

        
    }
}
