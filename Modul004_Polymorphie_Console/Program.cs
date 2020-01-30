using Modul004_OOP_Lib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.Linq;
using System.IO;

namespace Modul004_Polymorphie_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Polymorphie Beispiel
            Flugzeug flugzeug = new Flugzeug("Lufthansa", 2001, 500, "blau", 22, 11000);
            Flugzeug flugzeug1 = new Flugzeug("Fogger Doppedecker", 1912, 50, "Rot", 10, 2000);

            PKW pkw1 = new PKW("Ferrarie", 1955, 220, "Rot", 2, 4);
            PKW pkw2 = new PKW("Trappi", 1955, 80, "Mausegrau", 4, 4);
            PKW pkw3 = new PKW("Mercedez", 2020, 260, "Schwarz", 4, 4);

            Schiff schiff = new Schiff("Gorck Fork", 1867, 15, Schiff.SchiffsTreibstoff.Wind, 5);
            Yacht yacht = new Yacht("Jeanneau", 1999, 18, Schiff.SchiffsTreibstoff.Diesel, 2, true);
            Yacht yacht1 = new Yacht("Black Pearl", 1788, 25, Schiff.SchiffsTreibstoff.Wind, 2, false);


            Garage dagobertsGarage = new Garage();
            dagobertsGarage.ParkeFahrzeugInGarage(flugzeug);
            dagobertsGarage.ParkeFahrzeugInGarage(flugzeug1);
            dagobertsGarage.ParkeFahrzeugInGarage(pkw1);
            dagobertsGarage.ParkeFahrzeugInGarage(pkw2);
            dagobertsGarage.ParkeFahrzeugInGarage(pkw3);
            dagobertsGarage.ParkeFahrzeugInGarage(schiff);
            dagobertsGarage.ParkeFahrzeugInGarage(yacht);
            dagobertsGarage.ParkeFahrzeugInGarage(yacht1);
            //Zeige mir mein Inventar der Garage an
            dagobertsGarage.WelcheFahrzeugeSindInDerGarage();
            Console.ReadKey();
            #endregion

            #region Hallo Lambda
            List<PKW> pkwListe = new List<PKW>();
            pkwListe.Add(pkw1);
            pkwListe.Add(pkw2);
            pkwListe.Add(pkw3);
            pkwListe.Add(new PKW("BMW", 2001, 180, "grau", 3, 3));
            pkwListe.Add(new PKW("BMW", 2002, 222, "rot", 4, 4));
            pkwListe.Add(new PKW("Mercedez", 2019, 300, "blau", 4, 4));


            List<PKW> filterdList = pkwListe.Where(n => n.AnzahlTueren == 4).ToList();

            //Labda benutzt das Fluent-Pattern: .LambdaMethode(n=>n.IrgendEineProperty==true).LambdaMethode(n=>n.IrgendEineProperty==true);
            List<PKW> filterdList1 = pkwListe.Where(n => n.Marke == "Mercedez" && n.MaxGeschwindigkeit > 100).OrderBy(n => n.Baujahr).ToList();

            //PKW resultPKW = pkwListe.Single(n => n.ID == "IregendeineGuid");

            //if (resultPKW != null)
            //{
            //    if (resultPKW.ID != Guid.Empty)
            //    {

            //    }
            //}


            #endregion

            #region Exception Benutzen
            //https://docs.microsoft.com/de-de/dotnet/standard/exceptions/best-practices-for-exceptions
            try
            {
                Console.Write("Eingabe>");
                string eingabe = Console.ReadLine();
                int a = int.Parse(eingabe);

                throw new MeineException();
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Du musst eine Zahl eingeben.\n" + ex.Message);
                throw;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Deine Zahl ist zu groß/klein.");

            }
            catch (MeineException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ein unbekannter Fehler ist aufgetreten");

            }
            finally
            {
                Console.WriteLine("Wird immer ausgeführt");
            }


            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("zahlen.txt");

                for (int i = 0; i < 100; i++)
                {
                    sw.WriteLine(i);

                    if (i < 50)
                        continue;

                    Console.WriteLine(i);
                }
            }
            catch (Exception ex)
            {
                //Logdatei beschreiben
                throw;
            }
            finally
            {
                sw.Close();
            }


            #endregion

        }
    }
}
