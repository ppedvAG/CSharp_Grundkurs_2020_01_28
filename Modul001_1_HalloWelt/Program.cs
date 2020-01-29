using System;
using System.Text;
using System.IO;


namespace Modul001_1_HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Erstes Programm
            // Ausgabe eines Strings "Hallo Welt"
            Console.WriteLine("Hallo Welt");
            Console.ReadKey();
            #endregion




            #region Variablen stellen sich vor

            int alter = 36;
            string name = "Kevin";

            Console.WriteLine($"Ich bin {name} und bin {alter} alt");
            // Ausgabe des Wertebereiches einer Variable ínt.MinValue /int.MaxValue
            Console.WriteLine($"Bereich von Integer {int.MinValue} - {int.MaxValue}");
            Console.ReadKey();
            #endregion

            #region Weitere VariablenTypen (Gleitkommatypen)
            https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
            const decimal pi = 3.14m;

            double d = 4.343D;

            d = 5.564545D;

            float f = 5.434f;

            // decimal für Geldbeträge zu verwenden ist. Hat die genauste Beschreibung nach der Kommastelle
            decimal myMoneyValue = 3000.5m;

            
            #endregion

            #region Zeichenketten und Zeichen
            char ichBinEinBuchstabe = 'e';
            string ichBinEineZeichenkette = "Halle liebe Teilnehmner";

            Console.WriteLine($"{ichBinEinBuchstabe} {ichBinEineZeichenkette}");
            #endregion

            #region Ausgabe von Variablen
            Console.WriteLine("Ich bin" + name + " und bin " + alter + " alt"); //Schlechte Variante

            //Ausgabe via Index -> C++ wie printf
            Console.WriteLine("Ich bin {0} und bin {1} alt", name, alter);

            //seit C#6
            Console.WriteLine($"Ich bin {name} und bin {alter} alt");
            int a = 10;
            int b = 15;

            Console.WriteLine($"Ergebnis ist: {a + b}");

            //Escape Zeichen
            //https://docs.microsoft.com/de-de/dotnet/standard/base-types/character-escapes-in-regular-expressions
            Console.WriteLine($"Tabelle: Personen");
            Console.WriteLine($"Vorname\t\tNachname");

            //String-Formatierung mittels VerbaTim-String (Einleitung mittels @ / Escape-Sequenzen sind nicht möglich, 
            string dateiPfad = @"C:\Windows";

            string relativerPfad = @"..\Subversion";
            
            Console.WriteLine($"Ausgabe des Verzeichnispfades {dateiPfad}");

            //Problem mit dem € Zeichen
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("€");
            Console.ReadKey();
            #endregion

            #region Konsoleneingabe
            //Eingabe eines Strings durch den Benutzer und Abspeichern in einer String-Variablen
            Console.WriteLine("Bitte gebe deinen Namen ein: ");
            string myName = Console.ReadLine();
            Console.WriteLine($"Du heißt also {myName}.");
            Console.ReadKey();

            Console.Write("Bitte gib eine Zahl ein: ");
            string zahlAlsString = Console.ReadLine();
            int umgewandelteZahl = int.Parse(zahlAlsString);
            int umgewandelteZahl1 = Convert.ToInt32(zahlAlsString);

            int umgewandelteZahl2;

            int? nullableIntegerValue = null;
            nullableIntegerValue = 5;

            
            if (nullableIntegerValue.HasValue)
            {
                // Integerwert enthalten.
            }
            else
            {
                //
            }

            string dateiPfad1 = string.Empty;

            
            if (!string.IsNullOrEmpty(dateiPfad1) )
            {
                //string ist befüllt
            }

            string decimalString = "4.454545";
            decimal decValue;
            if (decimal.TryParse(decimalString, out decValue))
            {
                Console.WriteLine(decValue);
            }
            
            if (int.TryParse(zahlAlsString, out umgewandelteZahl2))
            {
                // Parsen hat funktioniert
                
            }
            else
            {

            }
            #endregion

            #region Casting Fallstricke Runden/Abschneiden
            double doubleValue = 3.5d;
            int intValue = (int)(doubleValue); // intValue = 3
            int intValue1 = Convert.ToInt32(doubleValue); //intValue1 = 4
            #endregion 

            int x = 10;
            int y = 15;
            int ergebnis = 0;

            //Console.WriteLine(++x);

            //ergebnis = x++ + --y;

            //Console.WriteLine($"Ergebnis : {ergebnis}");

            //Console.ReadKey();
            var i = 300;
            var ortname = "Berlin";
            var EinZeichen = 'C';

            Console.WriteLine(i.GetType());
            Console.WriteLine(ortname.GetType());
            Console.WriteLine(EinZeichen.GetType());

            int c = Math.Max(a, b);

        }
    }
}
