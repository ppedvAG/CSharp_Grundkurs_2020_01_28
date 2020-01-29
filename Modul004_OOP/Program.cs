using Modul004_OOP_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_OOP_Lib
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug fahrzeug1; //Deklaration
            fahrzeug1 = new Fahrzeug(); //Instanziierung

            //Fahrzeug fahrzeug2 = new Fahrzeug() { Marke = "VW", Farbe = "Blau", Baujahr = 1999, MaxGeschwindigkeit = 200, AktGeschwindigkeit = 0 };
            Fahrzeug fahrzeug3 = new Fahrzeug(2001, "Nissan", 160, "Blau");
            Console.WriteLine(Fahrzeug.AnzahlErstellterFahrzeuge);


            Flugzeug flugzeug = new Flugzeug("Lufthansa", 1999, 400, "black", 20, 10000);

            Console.WriteLine(Flugzeug.ZeigeAnzahlFahrzeuge());
            Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());

            Console.ReadKey();
        }
    }
}

