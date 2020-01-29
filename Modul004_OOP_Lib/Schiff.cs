using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_OOP_Lib
{
    public class Schiff : Fahrzeug
    {
        public enum SchiffsTreibstoff { Diesel = 0, Dampf, Wind, Muskelkraft }

        public SchiffsTreibstoff Treibstoff { get; set; }
        public double Tiefgang { get; set; }

        public Schiff(string marke, int baujahr, double maxGeschwindigkeit, SchiffsTreibstoff treibstoff, double tiefgang)
            : base(baujahr, marke, maxGeschwindigkeit)
        {
            this.Treibstoff = treibstoff;
            this.Tiefgang = tiefgang;
        }
    }
}
