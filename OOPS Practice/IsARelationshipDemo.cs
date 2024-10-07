using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    public class IsARelationshipDemo
    {
        static void Main2(string[] args)
        {
            Cuboid obj = new Cuboid(10, 20, 30);
            Console.WriteLine($"Cuboid voulme is {obj.Volume()}");
            Console.WriteLine($"Rectangle Area is {obj.Area()}");
            Console.WriteLine($"Rectangle Perimeter is {obj.Perimeter()}");
            Console.ReadKey();
        }


    }
    public class Rectangle
    {
        public int Lenght { get; set; }
        public int Breadth { get; set; }

        public int Area()
        {
            return Breadth * Lenght;

        }
        public int Perimeter()
        {
            return 2 * (Lenght + Breadth);
        }
    }
    public class Cuboid:Rectangle
    {
        public int Height { get; set; }

        public  Cuboid(int l,int h, int b)
        {Lenght = l; Breadth = h;Height = h;


        }
        public int Volume()
        {
            return Lenght*Height*Breadth;
        }
    }

}

