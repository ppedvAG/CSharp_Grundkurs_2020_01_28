using System;
using System.Collections.Generic;
using System.Linq;



namespace Modul003_01_Functions
{
    class Program
    {
        //Hallo Methode
        public static int Addiere(int a, int b)
        {
            return a + b;
        }

        //Überlagerung der Addiere-Methode
        public static int Addiere(int a, int b, int c)
        {
            return a + b + c;
        }

        public static void Subtraktion (int a, int b, out int Ergebnis)
        {
            Ergebnis = a - b;
        }


        /// <summary>
        /// Dies ist eine Multipliaktion mit einer Paramterliste, die nicht so zu verwendenen. 2 ReturnValues sind nicht schlecht
        /// 
        /// Alternative Kommentarmöglichkeiten via -> https://submain.com/products/ghostdoc.aspx
        /// </summary>
        /// <param name="a">Multiplator1</param>
        /// <param name="b">Multiplator1</param>
        /// <param name="Ergebnis">Ergebnis</param>
        /// <returns></returns>
        public static int Multiplikation (int a, int b, out int Ergebnis)
        {

            int value1 = 0;
            int value2 = 1;
            int value3 = 2;

            value1 = value2 = value3 = 5;

            return Ergebnis = a * b;
        }


        public static int BildeSumme(params int[] summanden)
        {
            //https://stackoverflow.com/questions/7580277/why-use-the-params-keyword
            int summe = 0;

            foreach (int item in summanden)
            {
                summe += item;
            }

            return summe;
        }



        

        static void Main(string[] args)
        {
            int summe = Addiere(5, 10);
            int suumm1 = Addiere(5, 10, 15);

            //Parametertyp out
            int Ergebnis = 0;
            Subtraktion(20, 5, out Ergebnis);

            // Worse Case
            Ergebnis = 0;
            int Ergebnis1 = Multiplikation(5, 5, out Ergebnis);

            Console.WriteLine($"Ergebnis: {Ergebnis}");
            Console.WriteLine($"Ergebnis1: {Ergebnis1}");

            //Parametertyp Params
            List<int> valueList = new List<int>();
            

            //Depency Injections -> Gibt mir eine Teilmenge der Methoden / Properties aus der List-Klasse zurück
            IList<int> valueList1 = new List<int>();

            valueList.Add(5);
            valueList.Add(7);
            valueList.Add(12);
            valueList.Add(18);
            int ergebnis1 = BildeSumme(valueList.ToArray());

            #region weitere generische Strukturen
            //Praktisches Beispiel ist ein Kartenstapel. Die letzte Karte die auf den Stabel draufgelegt wird, wird mithilfe von Pop/Peek ausgelesen. 
            Stack<string> stack = new Stack<string>();
            stack.Push("Eins");
            stack.Push("Zwei");
            stack.Push("Drei");

            //Pop = letzter Eintrag wird ausgelesen und aus dem Stack gelöscht
            string resultString = stack.Pop();
            //Peek = letzter Eintrag wird ausgelesen, Eintrag wird im Stack nicht gelöscht.
            string resultString2 = stack.Peek();

            Queue<string> stringQueue = new Queue<string>();
            stringQueue.Enqueue("Element1");
            stringQueue.Enqueue("Element2");
            stringQueue.Enqueue("Element3");

            //Ausgabe: Element1 wird ausgegeben und Element1 wird aus der Queue gelöscht
            string resultString3 = stringQueue.Dequeue();
            //Ausgabe: Element1 wird ausgegeben und Element1 wird aus der Queue erhalten
            string reuultString4 = stringQueue.Peek();
            #endregion


            #region Dictionary
            
            Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();
           
            dictionary.Add(Guid.NewGuid(), "BMW");

            Guid key = Guid.NewGuid();

            if (!dictionary.ContainsKey(key))
            {
                
                dictionary.Add(key, "Mercedez");
            }

            if(!dictionary.ContainsValue("VW"))
            {
                dictionary.Add(Guid.NewGuid(), "VW");
            }

            //Mercedes wird ausgegeben
            string autmarke = dictionary[key];

            foreach (KeyValuePair<Guid, string> item in dictionary)
            {
                //Schleifendurchlauf mit foreach
            }

            //Optionale Parameter ->https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments

            #endregion
        }
    }
}
