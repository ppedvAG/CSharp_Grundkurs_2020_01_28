using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_OOP_Lib
{
    public class MeineException : Exception
    {
        public MeineException()
            : base("Dies ist mein Fehler.")
        {

        }
    }
}
