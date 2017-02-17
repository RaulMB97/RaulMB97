using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactorització
{
    class Program
    {
        const double PI = 3.141592;

        static void Main(string[] args)
        {
            Console.WriteLine("Entra el radi: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entra la altura: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Volum: " + CalcularVolum(r, a));
        }

        private static double CalcularVolum(double radi, double altura)
        {
            double area = CalcularArea(radi);

            return area * altura;
        }

        private static double CalcularArea(double radi)
        {
            return PI * radi * radi;
        }

        class Cilindre : ICilindre1
        {
            private double altura;
            private double area;
            private double radi;

            public double Altura
            {
                get
                {
                    return altura;
                }

                set
                {
                    altura = value;
                }
            }

            public double Area
            {
                get
                {
                    return area;
                }

                set
                {
                    area = value;
                }
            }

            public double Radi
            {
                get
                {
                    return radi;
                }

                set
                {
                    radi = value;
                }
            }
        }
    }
}
