using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_OOP_Lib
{
    public class Yacht : Schiff, ICloneable
    {
        public bool Pool { get; set; }

        public Yacht(string marke, int baujahr, double maxGeschwindigkeit, SchiffsTreibstoff treibstoff, double tiefgang, bool pool)
            : base(marke, baujahr, maxGeschwindigkeit, treibstoff, tiefgang)
        {

        }

        public Yacht(Schiff schiff, bool pool)
            : base(schiff.Marke, schiff.Baujahr, schiff.MaxGeschwindigkeit, schiff.Treibstoff, schiff.Tiefgang)
        {
            this.Pool = pool;
        }

        public object Clone()
        {
            return new Yacht(this.Marke, this.Baujahr, this.MaxGeschwindigkeit, this.Treibstoff, this.Tiefgang, this.Pool);
        }
    }
}
