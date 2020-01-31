using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_OOP_Lib
{
    public class Garage
    {
        private List<Fahrzeug> fahrzeugListe = new List<Fahrzeug>();

        public Garage()
        {

        }

        public List<Fahrzeug> FahrzeugListe { get => fahrzeugListe; set => fahrzeugListe = value; }

        /// <summary>
        /// Übergeben werden kann: Fahrzeug - Flugzeug / Schiff / Yacht / PKW / Zug
        /// </summary>
        /// <param name="fahrzeug"></param>
        public void ParkeFahrzeugInGarage(Fahrzeug fahrzeug)
        {
            FahrzeugListe.Add(fahrzeug);
        }

        public void DoppeleAlleFahrzeugeDieEsKoennen()
        {
            List<Fahrzeug> kopierteFahrzeuge = new List<Fahrzeug>();

            foreach (Fahrzeug currentFahrzeug in FahrzeugListe)
            {
                if (currentFahrzeug is ICloneable)
                {
                    ICloneable clonbareFahrzeug = (ICloneable)currentFahrzeug;
                    
                    Fahrzeug clonedVehicle = (Fahrzeug)clonbareFahrzeug.Clone();
                    clonedVehicle.Farbe = "gelb";
                    kopierteFahrzeuge.Add(clonedVehicle);
                }
            }
            foreach (Fahrzeug currentFahrzeug in kopierteFahrzeuge)
                fahrzeugListe.Add(currentFahrzeug);

            FahrzeugListe.AddRange(kopierteFahrzeuge);
        }

        public void WelcheFahrzeugeSindInDerGarage()
        {
            int pkwCounter = 0;
            int flugzeugCounter = 0;
            int schiffCounter = 0;
            int yachtCounter = 0;

            foreach (Fahrzeug currentFahrzeug in FahrzeugListe)
            {

                if (currentFahrzeug is PKW)
                {
                    if (currentFahrzeug.Marke == "Ferrarie")
                    {
                        //...
                        //Ferrarie muss nach Italien zur Repatur 
                    }
                    pkwCounter++;
                }
                else if (currentFahrzeug is Flugzeug)
                {
                    flugzeugCounter++;
                }
                else if (currentFahrzeug is Yacht)
                {
                    yachtCounter++;
                }
                else if (currentFahrzeug is Schiff)
                {
                    schiffCounter++;
                }
            }

            Console.WriteLine($"---- Garageninventar ---- ");
            Console.WriteLine($"PKW-Anzahl:\t\t{pkwCounter} ");
            Console.WriteLine($"Flugzeug-Anzahl:\t{flugzeugCounter}");
            Console.WriteLine($"Schiff-Anzahl: \t\t{schiffCounter}");
            Console.WriteLine($"Yacht-Anzahl: \t\t{yachtCounter}");
        }




    }
}
