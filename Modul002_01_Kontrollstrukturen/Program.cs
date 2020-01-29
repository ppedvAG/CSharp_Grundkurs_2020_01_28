using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul002_01_Kontrollstrukturen
{
    enum Wochentag { Montag, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag}
    enum ToDo { Schlafen, Arbeiten, Freizeit }

    

    [Flags]
    enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };

    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 30;

            #region if-Statement
            //if + Tab + Tab Shortcut
            if (a < b)
            {
                Console.WriteLine("A ist kleiner als B");
            }
            else if (a > b)
            {
                Console.WriteLine("B ist kleiner als A");
            }
            else
            {
                Console.WriteLine("A und B sind gleich");
            }
            #endregion

            #region if -shortcut version

            //Kurznotation:
            //(Bedingung) ? TrueAusgabe : FalseAusgabe
            string ergebnis = (a == b) ? "A ist gleich B" : " A ist ungleich B";
            #endregion

            #region for-Schleife
            //Zählergesteuerte Schleife
            StreamWriter sw = new StreamWriter("zahlen.txt");

            for (int i = 0; i < 100; i++)
            {
                sw.WriteLine(i);

                if (i < 50)
                    continue;

                Console.WriteLine(i);
            }
            sw.Close();

            Console.WriteLine("+++ Schreiben in Datei ist fertig +++");
            Console.ReadKey();

            //Kopfgesteuerten Schleife

            StreamReader sr = new StreamReader("zahlen.txt");
            int summe = 0;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                summe += int.Parse(line);
            }
            sr.Close();

            Console.WriteLine($"Ergebnis: {summe}");
            Console.ReadKey();
            #endregion

            #region do while
            a = 1;
            do
            {
                a *= 2;
                continue;
                //Console.WriteLine("Wird niemals ausgeführt");
            } while (a < 100);
            #endregion

            #region Array

            // indexbereich 0 - 6 | zahlenArray.Legth = 7
            //deklarieren eines Array mit gleichzeitiger Initialisierung
            int[] zahlenArray = { 2, 4, 56, 45, 32, 64, 23 };

            //Array ohne Initialisierung anlegen
            int[] zweitesZahlenArray = new int[5];
            //Index beginnt immer bei dem Wert 0
            zweitesZahlenArray[0] = 2; // Indexposition 0 
            zweitesZahlenArray[1] = 5;
            zweitesZahlenArray[2] = 34;
            zweitesZahlenArray[3] = 12;
            zweitesZahlenArray[4] = 54;

            List<string> alleFarben = new List<string>();

            alleFarben.Add("Blue");
            alleFarben.Add("White");
            alleFarben.Add("Orange");
            alleFarben.Add("Red");
            alleFarben.Add("Yellow");

            List<string> weitereFarben = new List<string>();
            weitereFarben.Add("green");
            weitereFarben.Add("Black");

            alleFarben.AddRange(weitereFarben.ToArray());
            //Hier würde eine OutOfRange Exception entstehen!!!!
            //zweitesZahlenArray[5] = 44;


            string einWort = "Wahnsinn!";
            char buchstabe;
            for (int i = 0; i < einWort.Length; i++)
            {
                buchstabe = einWort[i];
                Console.WriteLine(buchstabe);
            }
            Console.WriteLine("Weitere Ausgabe");
            foreach (var c in einWort)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();

            if (zahlenArray.Contains(32))
            {
                // Der Wert 32 wurde im Array gefunden
            }

            int hoechsterWertDesArrays = zahlenArray.Max();
            int niedrigsterWertDesArrays = zahlenArray.Min();
            int gesamteSummeEinesArrays = zahlenArray.Sum();
            int erstesElement = zahlenArray.First();
            int letztesElement = zahlenArray.Last();

            #endregion


            #region Enums
            
            string[] wTag = new string[7];
            wTag[0] = "Montag";
            wTag[1] = "Dienstag";

            Wochentag ausgewaehlterTag = Wochentag.Samstag;
            Type weekdays = typeof(Wochentag);

            int TagInDerWoche = (int)ausgewaehlterTag;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }

            //Bitmask 
            //https://www.oreilly.com/library/view/c-cookbook/0596003390/ch04s05.html

            Console.ReadKey();

            switch (ausgewaehlterTag)
            {
                case Wochentag.Montag:
                    break;
                case Wochentag.Dienstag:
                    break;
                case Wochentag.Mittwoch:
                    break;
                case Wochentag.Donnerstag:
                    break;
                case Wochentag.Freitag:
                    break;
                default:
                    Console.WriteLine("Wochenende");
                    break;
            };


            int colorValue = 0;
            colorValue += (int)Colors.Red;
            colorValue += (int)Colors.Blue;
            colorValue += (int)Colors.Yellow;


            //ADVANCED -> Nicht für Anfänger
            //Mittels des WHEN-Stichworts kann auf Eigenschaften des betrachteten Objekts näher eingegangen werden
            int a1 = 11;
            switch (a1)
            {
                case 5:
                    Console.WriteLine("Irgendwas");
                    break;
                //a wird in b eingelegt (zu überprüfende Variable wir für Bedingungsprüfung vorbereitet)
                //und mittels when auf eine Eigenschaft geprüft
                case int b1 when b1 > 10 && b1 < 20:
                    Console.WriteLine("a ist größer 10");
                    break;
                default:
                    break;
            }




            Console.ReadKey();

            

        #endregion
    }
    }
}
