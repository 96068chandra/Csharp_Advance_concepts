using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    public class AbstractionExamples
    {
        static void Main(string[] args)
        {

            ChildAbs child = new ChildAbs();
            child.Add(10, 2);
            child.Mul(10, 3);
            child.Div(20, 4);
            child.Sub(20, 5);
            child.Mod(20, 6);
            Parent parent = child;//Cannot create object to abstract parent class but we can reference

            parent.Add(10, 2);
            parent.Mul(10, 3);
            parent.Div(20, 4);
            parent.Sub(20, 5);//Cannont call mod function with parent object

            RectangleChild rectangle = new RectangleChild(10, 20);
            Console.WriteLine($"Area of Rectangle: {rectangle.Area()}");
            Triangle triangle = new Triangle(15, 25);
            Console.WriteLine($"Area of Triangle: {triangle.Area()}");
            Circle circle = new Circle(12);
            Console.WriteLine($"Area of Circle: {circle.Area()}");
            Cone cone = new Cone(5, 15);
            Console.WriteLine($"Area of Cone: {rectangle.Area()}");
            Console.ReadKey();
            Console.ReadKey();
        }

    }
    public abstract class Parent
    {
        public void Add(int x,int y)
        {
            Console.WriteLine($"Sum is {x+y}");
           
        }
        public void Sub(int x,int y)
        {
            Console.WriteLine($"Difference is {x - y}");
        }
        public abstract void Mul(int x,int y);
        public abstract void Div(int x,int y);



    }
    public  class ChildAbs:Parent
    {
        public override void Mul(int x, int y)
        {

            Console.WriteLine($"Multiple is {x * y}");
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine($"Division is {x/ y}");
        }
        public void Mod(int x,int y)
        { Console.WriteLine($"Mod is {x % y}");
        }

    }
}
