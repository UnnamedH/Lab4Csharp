using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp2b
{
    class Triangle
    {
        class STriangle
        {



            public double x1, y1, x2, y2, x3, y3, a, b, c, perimeter, ABx, ABy, ACx, ACy;
            bool var;

            public Triangle() { }

            public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
            {
                this.x1 = x1;
                this.y1 = y1;
                this.x2 = x2;
                this.y2 = y2;
                this.x3 = x3;
                this.y3 = y3;
            }

            public void printInfo()
            {

                a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
                Console.Write("\nДлина стороны AB: " + a);
                Console.Write("\nДлина стороны BC: " + b);
                Console.Write("\nДлина стороны AC: " + c);
                perimeter = a + b + c;
                Console.Write("\nПериметр равен: " + perimeter);
                Console.Write("\nПлощадь равна: " + Math.Sqrt((perimeter / 2) * ((perimeter / 2) - a) * ((perimeter / 2) - b) * ((perimeter / 2) - c)));
                Console.Write("\nУгол между AB и BC: " + Math.Acos(((x2 - x1) * (x3 - x2) + (y2 - y1) * (y3 - y2)) / (a * b)));
                Console.Write("\nУгол между BC и AC: " + Math.Acos(((x3 - x2) * (x3 - x1) + (y3 - y2) * (y3 - y1)) / (b * c)));
                Console.Write("\nУгол между BC и AC: " + Math.Acos(((x2 - x1) * (x3 - x1) + (y2 - y1) * (y3 - y1)) / (a * c)));
            }

            public bool isTriangle()
            {
                ABx = x2 - x1;
                ABy = y2 - y1;
                ACx = x3 - x1;
                ACy = y3 - y1;
                Console.WriteLine("\nABx" + ABx);
                Console.WriteLine("ABy" + ABy);
                Console.WriteLine("ACx" + ACx);
                Console.WriteLine("ACy" + ACy);
                if ((ACx / ABx) == (ACy / ABy))
                {
                    Console.WriteLine("\nНе является треугольником!");
                    var = true;
                }
                else
                {
                    Console.WriteLine("\nЯвляется треугольником!");
                    var = false;
                }
                return var;
            }
        }

        class EqualSideTriangle : STriangle
        {
            bool var2 = false;

            public EqualSideTriangle(double x1, double y1, double x2, double y2, double x3, double y3) : base(x1, y1, x2, y2, x3, y3)
            {

            }

            public bool isEqualSideTriangle()
            {
                if (!isTriangle() && a == b && b == c && c == a)
                {
                    var2 = true;
                    Console.WriteLine("Является равносторонним треугольником!");
                }
                return var2;
            }


            

        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Triangle triangle = new Triangle(5, 5, 5, 5, 5, 5, 5);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

