using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Ishape circle = new Circle(5);
            //CalculateArea(circle);
           //new Print(). Printer(circle);

           //Ishape reac = new Rectangle(10, 5);
           // CalculateArea(reac);
           // new Print().Printer(reac);
            Ishape squre = new Square(10);
            CalculateArea(squre);
            new Print().Printer(squre);

        }
        private static void CalculateArea(Ishape c)
        {
            Console.WriteLine(c.GetArea());
        }
    }
}
