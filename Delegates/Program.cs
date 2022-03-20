using System;

namespace Delegates
{
    class Program
    {
        public delegate int Rechenoperation(int x, int y);


        static void Main(string[] args)
        {
           
            Console.Write("Kontobestand: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lohn: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wähle Zuhname oder Abnahme");
            Console.WriteLine("Zunahme(1)");
            Console.WriteLine("Abnahme(2)");

            int auswahl = Convert.ToInt32(Console.ReadLine());

            Rechenoperation op;
            switch (auswahl) 
            {
                case 1:
                    op = new Rechenoperation(Zunahme);
                    break;

                case 2:
                    op = new Rechenoperation(Abnahme);
                    break;

                default:
                    op = new Rechenoperation(Zunahme);
                    break;

            }

            int ergebnis = op(zahl1, zahl2);

            Console.WriteLine("Ergebnis: "+ ergebnis);
            Console.ReadKey();
        }

        static int Zunahme(int x, int y)
        {
            return x + y;
        }

        static int Abnahme(int x, int y)
        {
            return x - y;
        }
    }
}
