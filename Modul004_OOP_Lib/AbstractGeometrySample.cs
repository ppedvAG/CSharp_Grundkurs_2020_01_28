
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;


namespace Modul004_OOP_Lib.Abstract
{
    public abstract class Shape
    {
        public abstract int GetArea();

        public const double PI = Math.PI;

        //Methode die eine gemeinsame Logik hat, nicht verändert werden muss, aber von abgeleiteten Klasse
        //verwendet werden kann. 
        public string GetHallo()
        {
            return "Hallo";
        }




        public virtual string GetVorname()
        {
            return "Hallo Max";
        }
    }

    public class Square : Shape
    {
        int side;

        public Square(int n)
        {
            side = n;
        }

        // GetArea method is required to avoid a compile-time error.
        public override int GetArea()
        {
            return side * side;
        }
    }



    public abstract class Maschine
    {
        public abstract string GetWartungsAnleitung();
        public abstract int WartungsZyklus();

        public FileStream GetLogDatei()
        {
            return new FileStream("LogDatei.log", FileMode.Open);
        }

        public virtual string GetSeriennummer()
        {
            return "abcdefg";
        }
    }

    public class R2D2 : Maschine
    {
        public override string GetWartungsAnleitung()
        {
            return "Keine Wartung benötigt, repariert sich selber";
        }

        public override int WartungsZyklus()
        {
            //Braucht keinen Zyklus. 
            return 0;
        }
    }

    public class Fließband : Maschine
    {
        public override string GetWartungsAnleitung()
        {
            return "Wartung";
        }

        public override int WartungsZyklus()
        {
            throw new NotImplementedException();
        }

        public override string GetSeriennummer()
        {
            return "12345";
        }
    }
}
