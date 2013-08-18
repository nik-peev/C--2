// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TriangleSurface
{
    class Program
    {
        private static float TriangleBySideAndHeight(float side, float height)
        {
            float area;
            area = side * height / 2;
            return area;
        }

        private static float TriangleByThreeSides(float side1, float side2, float side3)
        {
            float p = (side1 + side2 + side3) / 2;
            float area = (float)Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
            return area;
        }

        private static float TriangleByTwoSidesAndAngle(float side1, float side2, float angle)
        {
            float area;
            area =(float) (side1 * side2 * Math.Sin(angle)/2);
            return area;
        }

        static void Main(string[] args)
        {
            float side = 6;
            float height = 3;
            Console.WriteLine("The area of triangle with side {0} and height {1} is {2}!", side, height, TriangleBySideAndHeight(side, height));
            float a = 5;
            float b = 3;
            float c = 7;
            Console.WriteLine("The area of the triangle by three sides ({0},{1},{2}) is {3}!",a,b,c,TriangleByThreeSides(a,b,c));
            float side1 = 5;
            float side2 = 3;
            float angle =(float) Math.PI/4;
            Console.WriteLine("The area of the thiangle with sides {0} and {1} and angle between them {2} is {3}!",side1,side2,angle,TriangleByTwoSidesAndAngle(side1,side2,angle));
        }
    }
}
