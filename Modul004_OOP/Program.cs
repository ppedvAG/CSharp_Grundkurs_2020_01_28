using Modul004_OOP_Lib;
using Modul004_OOP_Lib.Polymorphie;
using System;
using System.Collections;
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
            Console.WriteLine(flugzeug.ToString());
            Console.WriteLine(Flugzeug.ZeigeAnzahlFahrzeuge());
            Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());


            Console.WriteLine("--------- Virtual Sample - Calc Area");

            double r = 3.0, h = 5.0;
            Circle c = new Circle(r);
            Sphere s = new Sphere(r);
            Cylinder l = new Cylinder(r, h);
            Rectangle rectangle = new Rectangle(5, 5);

            // Display results.
            Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());

            Console.WriteLine("Area of Retancle = {0:F2}", rectangle.Area());
            Console.ReadKey();


            Console.WriteLine("abstact Sample");

            Modul004_OOP_Lib.Abstract.Square square = new Modul004_OOP_Lib.Abstract.Square(5);
            Console.WriteLine($"Flächenberechnung von Square: {square.GetArea()}");

            Console.WriteLine($"Rufe Methode aus der Basisklasse (abstrakte Klasse) auf {square.GetHallo()}");

            Console.ReadKey();

            #region Polymorphie
            // Polymorphism at work #1: a Rectangle, Triangle and Circle
            // can all be used whereever a Shape is expected. No cast is
            // required because an implicit conversion exists from a derived 
            // class to its base class.
            List < Modul004_OOP_Lib.Polymorphie.Shape> shapes = new List<Polymorphie.Shape>
            {

            
                new Modul004_OOP_Lib.Polymorphie.Rectangle(),
                new Modul004_OOP_Lib.Polymorphie.Triangle(),
                new Modul004_OOP_Lib.Polymorphie.Circle(),
                new Modul004_OOP_Lib.Polymorphie.Quater()
            };
            Modul004_OOP_Lib.Polymorphie.Rectangle r1 = new Polymorphie.Rectangle();

            shapes.Add(r1);
            r1.X = 1;
            r1.Y = 2;

            Modul004_OOP_Lib.Polymorphie.Circle c1 = new Polymorphie.Circle();
            c1.X = 11;
            c1.Y = 22;
            shapes.Add(c1);


            Hashtable hashtable = new Hashtable();

            hashtable.Add(Guid.NewGuid(), "Hallo");
            hashtable.Add(Guid.NewGuid(), 34);

            // Polymorphism at work #2: the virtual method Draw is
            // invoked on each of the derived classes, not the base class.
            foreach (var shape in shapes)
            {
                if (shape is Modul004_OOP_Lib.Polymorphie.Circle)
                {
                    //shape is ein Circle

                    shape.Draw();
                    Modul004_OOP_Lib.Polymorphie.Circle circle = (Modul004_OOP_Lib.Polymorphie.Circle)shape;

                    if (shape == c1)
                    {

                    }
                }
                shape.Draw();
            }

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            #endregion
        }
    }
}

