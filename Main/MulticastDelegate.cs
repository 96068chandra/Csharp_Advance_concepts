using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public delegate void RectangleDelegare(double Width,double Height);
    public class MulticastDelegate
    {
        static void Main(string[] args)
        {
            MulticastDelegate multicastDelegate = new MulticastDelegate();
            RectangleDelegare rectangleDelegare = new RectangleDelegare(multicastDelegate.GetArea);
            rectangleDelegare += multicastDelegate.GetPerimeter;
            Delegate[] delegates=rectangleDelegare.GetInvocationList();
            Console.WriteLine("Invocation List");
            foreach(Delegate delegator in delegates)
            {
                Console.WriteLine($"  {delegator}");
            }
            Console.WriteLine();
            Console.WriteLine("Invoking Multicase Delegate::");
            rectangleDelegare(20, 30);
            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate After Removing one Pipeline:");
            rectangleDelegare -= multicastDelegate.GetPerimeter;
            rectangleDelegare(30, 40);
            Console.ReadKey();
        }

        public void GetArea(double Width, double Height)
        {
            Console.WriteLine($"Area is {Width * Height}");
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine($"Perimeter is {2 * (Width + Height)}");
        }
    }
}
