using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    public abstract class Shape
    {
        public double Length;
        public double Breadth;
        public double Heigth;
        public double Radius;
        public float Pi = 3.14F;
        public abstract double Area();


    }

    public class RectangleChild : Shape
    {
        public RectangleChild(double lenght, double breadth)
        {
            Length = lenght;
            Breadth = breadth;

        }
        public override double Area()
        {
            return Length * Breadth;
        }
    }

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Pi*Radius*Radius;
        }
    }
    public class Cone : Shape
    {
        public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Heigth = Height;
        }
        public override double Area()
        {
            return Pi * Radius * (Radius + Math.Sqrt(Heigth * Heigth + Radius * Radius));
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double Heigth,double Breadth)
        {
            this.Heigth = Heigth;
            this.Breadth= Breadth;
            
        }
        public override double Area()
        {
            return (Heigth * Breadth) / 2;
        }

    }
}


