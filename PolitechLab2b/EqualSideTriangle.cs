using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitechLab2b
{
    class EqualSideTriangle : Triangle
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
    
}
