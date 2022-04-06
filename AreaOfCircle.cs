using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleConsoleApp5
{
    internal class Program
    {
        public static void matter(double r)
        {
            Console.WriteLine("Give radius value to calculate Area of circle and circumference of the circle in a client method");
            double pie = 3.142;
            double area_of_circle = pie * r * r;
            double circumference_of_circle = 2* pie * r;
            Console.WriteLine("Area of the circle = {0} ", + area_of_circle);
            Console.WriteLine("circumference of the circle = {0} ", + circumference_of_circle);         
        }
        public static void Main(string[] args)
        {
            matter(95);

        }
    }
}
