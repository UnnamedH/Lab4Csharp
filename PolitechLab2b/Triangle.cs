using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitechLab2b
{
    class Triangle
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

            public double getSideA()
            {
                a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                return a;
            }

            public double getSideB()
            {
                b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                return b;
            }

            public double getSideC()
            {
                c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
                return c;
            }

            public double getPerimetr()
            {
                perimeter = a + b + c;
                return perimeter;
            }

            public double getSquare()
            { 
                return Math.Sqrt((perimeter / 2) * ((perimeter / 2) - a) * ((perimeter / 2) - b) * ((perimeter / 2) - c));
            }

            public double getCosABBC()
            {
                return Math.Cos(((x2 - x1) * (x3 - x2)+ (y2 - y1) * (y3 - y2)) / (a * b));
            }

            public double getCosBCAC()
            {
                return Math.Cos(((x3 - x2) * (x3 - x1) + (y3 - y2) * (y3 - y1)) / (a * b));
            }

            public double getCosACAB()
            {
                return Math.Cos(((x1 - x3) * (x2 - x1) + (y1 - y3) * (y2 - y1)) / (a * b));
            }

        public bool isTriangle()
            {
            if (PointsEqual(x1,x2,y1,y2)  || PointsEqual(x1, x3, y1, y3) || PointsEqual(x2, x3, y2, y3))
            {
                return false;
            }
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
                    var = false;
                }
                else
                {
                    Console.WriteLine("\nЯвляется треугольником!");
                    var = true;
                }
                return var;
            }
        bool PointsEqual(double x, double y, double X, double Y)
        {
            return (x1 == x2) && (y1 == y2);
        }

        }
        

    
}
