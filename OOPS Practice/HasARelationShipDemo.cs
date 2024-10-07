using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    public class HasARelationShipDemo
    {
        static void Main2(string[] args)
        {
            Address add1 = new Address("XXX", "YYY", "Bangalore", "Karnataka", 560032);
            Employee e1 = new Employee(1, add1, "Chandra");
            e1.Display();
            Console.ReadKey();

        }
    }
    public class Address
    {

        public string AddressLine1, AddressLine2, City, State;
        public int Pincode;
        public Address(string addressLine1,string addressLine2,string city,string state,int pincode)
        { 

            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            State = state;
            Pincode = pincode;
        }

    }

    public class Employee
    {
        public int Id;
        public Address Address;
        public string Name;
        public Employee(int id,Address address,string name)
        { 
            Id = id;
            Address = address;
                Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Employee ID:{Id}");
            Console.WriteLine($"Employee Name:{Name}");
            Console.WriteLine($"Employee Address:{Address.AddressLine1 +"," + Address.AddressLine2 + "," + Address.City + "," + Address.State + "," + Address.Pincode}");

        }
        
    }
}
