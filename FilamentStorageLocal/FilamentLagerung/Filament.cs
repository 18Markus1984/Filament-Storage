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

        public Filament(string marke, double durchmesser, string art, string farbe, Color color, string druckkopf, int geöffnet, int meneg, bool keller,int filamentBild)
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
    }
}
