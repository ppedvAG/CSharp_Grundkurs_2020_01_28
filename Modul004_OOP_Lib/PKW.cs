using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_OOP_Lib
{
    public class PKW : Fahrzeug, IBewegbar, ICloneable
    {
        #region Auto-Properties
        public int AnzahlTueren { get; set; }
        public int AnzahlRaeder { get; set; }
        public int AnzahlRaederAktuell { get; set; }
        
        #endregion

        public PKW(string marke, int baujahr, double maxGeschwindigkeit, string farbe, int anzahlTueren, int anzahlRaeder)
            : base(baujahr, marke, maxGeschwindigkeit, farbe)
        {
            this.AnzahlTueren = anzahlTueren;
            this.AnzahlRaeder = anzahlRaeder;
        }

        #region IBewegbar
        public int RaederanzahlZumLenken { get; set; }
        public void Bewegen()
        {
            

            Console.WriteLine($"Raederanzahl die zum lenken benötigt werden: {RaederanzahlZumLenken}");
        }
        #endregion

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }



        #region ICloneable
        public object Clone()
        {

            return new PKW(this.Marke, this.Baujahr, this.MaxGeschwindigkeit, this.Farbe, this.AnzahlTueren, this.AnzahlRaeder);
        }
        #endregion
    }
}
