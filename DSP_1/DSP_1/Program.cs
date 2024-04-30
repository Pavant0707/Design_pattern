using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            CalculateArea(circle);
            print(circle);
        }

        private static void print(Circle circle)
        {
            double area = Math.PI * circle.radius * circle.radius;
            Console.WriteLine(area);
        }

        private static void CalculateArea(object circle)
        {
            Console.WriteLine(circle);
        }
    }
    
}
