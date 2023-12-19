using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neboderKlasa
{
    internal class neboder
    {
        float visina, katovi;


        public void setVisina(int visina)
        {
            this.visina = visina;
        }
        public float GetVisina()
        {
            return this.visina;
        }

        public void setKatovi(int katovi)
        {
            this.katovi = katovi;
        }
        public float GetKatovi()
        {
            return this.katovi;
        }

        public override string ToString()
        {
            string ispis = "Visina: " + this.GetVisina() + "m\n" + "katovi: " + this.GetKatovi() + "\n"
                + "Prosijek je --> " + this.GetVisina() / this.GetKatovi() + " kata";
            return ispis;
        }
        public neboder(int visina, int katovi) { this.visina = visina; this.katovi = katovi; }

    }
}
