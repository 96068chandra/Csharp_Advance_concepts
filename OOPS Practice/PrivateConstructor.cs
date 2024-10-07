using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    public class PrivateConstructor
    {
        private PrivateConstructor()
        {
            Console.WriteLine("Private Constructor called:Parent");
            
        }
        public PrivateConstructor(string msg)
        {
            Console.WriteLine("Public constructor is called:Parent");
        }
        
    }
    public class  Child:PrivateConstructor
    {
        public Child():base("hello")
        {
            Console.WriteLine("Child class constructor is called:Child");

        }
        
    }
    public class Program2
    {
        static void Main2(string[] args)
        {
            Child obj1= new Child();
            Console.ReadKey();
                
        }


    }
}
