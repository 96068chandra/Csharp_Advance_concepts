using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    public class Program
    {



        //static void Main(string[] args)
        //{
        //    //Calculator calculator = new Calculator();
        //    //int res = calculator.CalculateSum(10, 20);
        //    //Console.WriteLine($"Sum is {res}");
        //    //Console.WriteLine($"dafault values i:{calculator.i}");
        //    //Console.WriteLine($"dafault values a:{calculator.a}");
        //    //Console.WriteLine($"dafault values var:{calculator.var}");
        //    //Console.WriteLine("Enter input value");
        //    //int i = Convert.ToInt32(Console.ReadLine());
        //    //ParameterizedConstructor constructor = new ParameterizedConstructor(i);
        //    //constructor.Display();

        //    PramaterizedConstructorRealTimeExample obj = new PramaterizedConstructorRealTimeExample(1, 20, "Chandra", "XXX", true);
            
        //    PramaterizedConstructorRealTimeExample obj2 = new PramaterizedConstructorRealTimeExample(2, 20, "Shekar", "XYX", false);
        //    obj.PrintDetails();
        //    obj2.PrintDetails();
        //    Console.ReadKey();



        //}
    }

    public class Calculator
    {

        public int i;
        public string var;
        public bool a;

        public int CalculateSum(int a1, int a2)
        {

            return a1 + a2;
        }
    }

    public class ParameterizedConstructor
    {
        int x;
        public ParameterizedConstructor(int i)
        {
            this.x = i;
            Console.WriteLine($"Parameterized Constructor is called{i}");


        }
        public void Display()
        {
            Console.WriteLine($"value of x is{x}");
        }
    }

    public class PramaterizedConstructorRealTimeExample
    {
        public int id, age;
        public string name, address;
        public bool isPermanent;
        public PramaterizedConstructorRealTimeExample(int id, int age, string name, string address, bool ispermamnent)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.address = address;
            this.isPermanent = ispermamnent;


        }
        public void PrintDetails()
        {
            Console.WriteLine($"id is: {id}");
            Console.WriteLine($"Name is :{name}");
            Console.WriteLine($"Age is : {age}");
            Console.WriteLine($"Address is : {address}");
            Console.WriteLine($"Ispermananet : {isPermanent}");
            
        }
    }

}
