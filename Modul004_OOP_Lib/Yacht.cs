using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_OOP_Lib
{
    public class Yacht : Schiff
    {
        public bool Pool { get; set; }

        public Yacht(Schiff schiff, bool pool)
            : base(schiff.Marke, schiff.Baujahr, schiff.MaxGeschwindigkeit, schiff.Treibstoff, schiff.Tiefgang)
        {
            this.Pool = pool;
        }

    }
}
