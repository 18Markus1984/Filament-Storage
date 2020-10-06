using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

namespace FilamentLagerung
{
    public partial class Form1 : Form
    {
       
        public List<Filament> filaments = new List<Filament>();
        public Form1()
        {
            InitializeComponent();
            filaments = ReadData();
            Refresh();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NeuFilament neuFilament = new NeuFilament(this);
            neuFilament.Show();
        }

        public void SaveData(List<Filament> filamentList)
        {
            //File.WriteAllText("filamentData.dat", new JavaScriptSerializer().Serialize(filamentList));
            File.WriteAllText("filamentData.dat", JsonConvert.SerializeObject(filamentList));
        }

        public List<Filament> ReadData()
        {
            if (File.Exists("filamentData.dat"))
            {
                //return new JavaScriptSerializer().Deserialize<List<Filament>>(File.ReadAllText("filamentData.dat"));
                return JsonConvert.DeserializeObject<List<Filament>>(File.ReadAllText("filamentData.dat"));
            }
            else
            {
                return new List<Filament>();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Remove(PanelFilament panel)
        {
            filaments.Remove(panel.filament);
            if (File.Exists(@".\Images\" + panel.filament.filamentBild + ".jpg"))
            {
                File.Delete(@".\Images\" + panel.filament.filamentBild + ".jpg");
            }
            Refresh();
        }

        public void SpeichernvonDaten(Filament filament)
        {
            filaments.Add(filament);
            Refresh();
        }

        public void Refresh()
        {
            Lager.Controls.Clear();
            foreach (var item in filaments)
            {
                Lager.Controls.Add(new PanelFilament(item, this));
            }
            SaveData(filaments);
        }
        
        public void RefreshValueChanged()
        {
            SaveData(filaments);
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dies hier soll einen kleine Hilfe für die Benutzung dieses Programmes sein." +
                "Wir haben eine Benutzeropberfläche bei der man neue Filamente erstellen kann alle alten bearbeiten kann.\n" +
                "\n1. Man kann mit dem rechtesten X das Filament löschen. " +
                "\n2. Mit dem linken X kommt man in feinere Einstellungen. " +
                "\n3. Die kleine Box an der Keller steht sagt aus, ob das Filament im Keller oder im Büro gelagert wird. " +
                "");
        }

        
    }
}
