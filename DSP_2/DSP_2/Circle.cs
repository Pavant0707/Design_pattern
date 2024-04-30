using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_2
{
    public interface Ishape
    {
         double GetArea();
    }
    class Circle:Ishape 
    {
        public double radius;
        public Circle(double radius)
        {
          this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius*radius;
        }
    }
    public class Rectangle:Ishape
    {
        public double length;
        public double Breadth;
        public Rectangle(double length, double Breadth) { 
        this.length = length;
        this.Breadth = Breadth;
        }
        public double GetArea()
        {
            return length*Breadth;
        }
    }
    public class Square:Ishape {
        public double side;
        public Square(double side)
        {
            this.side = side;
        }
        public double GetArea()
        {
            return side*side;
        }
    }
}
