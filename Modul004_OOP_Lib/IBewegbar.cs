using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_OOP_Lib
{
    public interface IBewegbar
    {
        int     RaederanzahlZumLenken { get; set; }
        void    Bewegen();
    }
}
