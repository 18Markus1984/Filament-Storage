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
using System.Runtime.InteropServices;


namespace FilamentLagerung
{
    public partial class Home : Form
    {
        private bool mouseDown;         //Die Maus ist auf dem Objekt gedrückt
        private Point lastLocation;     //Die letzte Position der Maus
        public bool resize = false;     //Darf die Größe der Form verändert werden

        public Dashboard dashboard;
        public Suche suche;
        public NeuFilament neuFilament;
        public Sellers sellers;
        public Materials materials;

        public Home()
        {
            suche = new Suche();
            neuFilament = new NeuFilament();
            sellers = new Sellers();
            materials = new Materials();

            InitializeComponent();
            

            int x = this.Height;
            this.Height = 650;
            x = this.Height;
            dashboard = new Dashboard(this);    //Das dashboard wird direkt am Anfang erstellt da es ja vonAnfang an gezeigt wird
            dashboard.StartPosition = FormStartPosition.Manual;
            dashboard.Location = new Point(0, 0);
            dashboard.MdiParent = this;
            ControlSize(dashboard);
            dashboard.Show();
        }
        
        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)       //Eine kleine Notiz um mit der Benutzung am Anfng besser klar kommt.
        {
            MessageBox.Show("Dies hier soll einen kleine Hilfe für die Benutzung dieses Programmes sein." +
                "Wir haben eine Benutzeropberfläche bei der man neue Filamente erstellen kann alle alten bearbeiten kann.\n" +
                "\n1. Man kann mit dem rechtesten X das Filament löschen. " +
                "\n\n2. Mit dem linken + kommt man in erweiterte Einstellungen. " +
                "\n\n3. Die kleine Box an der Keller steht sagt aus, ob das Filament im Keller oder im Büro gelagert wird. " +
                "");
        }

        private void close_Click(object sender, EventArgs e)        //eigner Close Button zum Schließen der Form
        {
            this.Close();
        }

        private void Menue_Click(object sender, EventArgs e)    //Alle Buttons haben die gleiche Methode und es wird am Ende geguckt welcher der Butttons gedrückt wurde und welche Form geöffnet werden muss
        {
            resize = false;
            Button button = (Button)sender;
            dashboard.Close();      //Alle Forms werden vor dem öffnen nocheinmal geschlossen
            suche.Close();
            neuFilament.Close();
            sellers.Close();
            materials.Close();
            

            if (button.Text == "Dashboard")
            {
                dashboard = new Dashboard(this);                       //Es wird eine neue Form mit dem Konstruktor mit Inhalt erstellt
                dashboard.StartPosition = FormStartPosition.Manual;    //Die Position der Form kann nun verändert werden
                dashboard.Location = new Point(0, 0);                  //Die neue Position ist 0|0
                dashboard.MdiParent = this;                            //Die Form wird als MDI Parent festgelegt
                ControlSize(dashboard);                                //Die Panels werden als Sichtsschutz an die Größe der Form agepasst
                dashboard.Show();                                      //Die Form wird angezeigt
                
            }
            else if (button.Text == "Verkäufer")
            {
                sellers = new Sellers(this,dashboard.marken.ds);        //Wie vorher
                sellers.StartPosition = FormStartPosition.Manual;
                sellers.Location = new Point(0, 0);
                sellers.MdiParent = this;
                ControlSize(sellers);
                sellers.Show();
            }
            else if (button.Text == "Materialien")
            {
                materials = new Materials(this);                        //Wie vorher
                materials.StartPosition = FormStartPosition.Manual;
                materials.Location = new Point(0, 0);
                materials.MdiParent = this;
                ControlSize(materials);
                materials.Show();
            }
            else if (button.Text == "Suchen")
            {
                resize = true;
                suche = new Suche(dashboard);                           //Wie vorher
                suche.StartPosition = FormStartPosition.Manual;
                suche.Location = new Point(0, 0);
                suche.MdiParent = this;
                ControlSize(suche);
                suche.Show();
            }
            else if (button.Text == "Hinzufügen")
            {
                neuFilament = new NeuFilament(dashboard);               //Wie vorher
                neuFilament.StartPosition = FormStartPosition.Manual;
                neuFilament.Location = new Point(0, 0);
                neuFilament.MdiParent = this;
                ControlSize(neuFilament);
                neuFilament.Show();
            }
        }

        public void ControlSize(Form form)      //Die Größer der Panels wird auf die Größe der Forms angepasst, damit diese den Hntergrund perfekt bedecken
        {
            this.Width = form.Width + 204 + 50;
            panel3.Width = this.Width - 204 - form.Width;
            panel5.Height = this.Height - 104 -form.Height;
        }

        private void button1_Click(object sender, EventArgs e)  //Minimiert die Form
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        

        private void panel3_MouseDown(object sender, MouseEventArgs e)      //gibt die Position der Maus zurück, wenn sie gedrückt wird
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);  //Die neu Position wird so berechnet, dass die aktuelle Position der Maus von der letzte Position subtrahiert wird und dieses Ergebnis wird dann zur aktuellen Position der Form hinzu addiert
                                                                                                                              
                this.Update();
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)        //Wenn die Maustaste wieder los gelassen wird
        {
            mouseDown = false;
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)      //Vergrößern und Verkleinern der Form 
        {
            if (mouseDown && resize && this.Width + (e.X - lastLocation.X ) >= 1200 && this.Height + (e.Y - lastLocation.Y) >= 650) //Die Form kann vergrößert werden, wenn der User auf der Suchseite ist und es gibt eine Maximal Größe
            {
                this.Size = new Size(this.Width + (e.X - lastLocation.X), this.Height + (e.Y - lastLocation.Y));      //Die Größe wird so berechnet, dass die aktuelle Position von der letzte Position subtrahiert wird und dieses Ergebnis wird dann zur Größe hinzu addiert
                suche.Size = new Size(suche.Width + (e.X - lastLocation.X), suche.Height + (e.Y - lastLocation.Y));
                this.Update();
            }

        }
    }
}
