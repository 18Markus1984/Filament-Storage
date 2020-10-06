using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace FilamentLagerung
{
    [Serializable]
    public class Filament
    {
        public string marke;
        public double durchmesser;
        public string art;
        public string farbe;
        public Color color;
        public string druckkopf;
        public int geöffnet;
        public int meneg;
        public float gewicht;
        public string materialnummer;
        public bool keller;
        public int druckbett;
        public int extruder;
        public string notizen;
        public int filamentBild;

        public Filament() { }

        public Filament(int filamentBild, string farbe, Color color, double durchmesser, string druckkopf, int meneg, int geöffnet, bool keller, string marke,string art)
        {
            this.marke = marke;
            this.durchmesser = durchmesser;
            this.art = art;
            this.farbe = farbe;
            this.color = color;
            this.druckkopf = druckkopf;
            this.geöffnet = geöffnet;
            this.meneg = meneg;
            this.keller = keller;
            this.filamentBild = filamentBild;
        }

        public Filament(int filamentBild, string farbe, Color color, int gewicht,string materialnummer, double durchmesser, string druckkopf, int meneg, int geöffnet,int druckbett, int extruder, bool keller,string notizen, string marke,string art)
        {
            this.marke = marke;
            this.durchmesser = durchmesser;
            this.art = art;
            this.farbe = farbe;
            this.color = color;
            this.druckkopf = druckkopf;
            this.geöffnet = geöffnet;
            this.meneg = meneg;
            this.gewicht = gewicht;
            this.materialnummer = materialnummer;
            this.keller = keller;
            this.druckbett = druckbett;
            this.extruder = extruder;
            this.notizen = notizen;
            this.filamentBild = filamentBild;
        }
    }
}
