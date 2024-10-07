
namespace GenericDelegatesDemo
{
    public class GenericDelegates
    {
        public delegate double AddNumber1Delegate(int no1, float no2, double no3);
        public delegate void AddNumber2Delegate(int no1, float no2, double no3);
        public delegate bool CheckLengthDelegate(string name);

        static void Main(string[] args)
        {
            //AddNumber1Delegate obj1 = new AddNumber1Delegate(AddNumber1);
            Func<int, float, double, double> func = new Func<int, float, double, double>(AddNumber1);
            double Result = func.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(Result);

           
            
           
            //AddNumber2Delegate obj2 = new AddNumber2Delegate(AddNumber2);
            Action<int, float, double> action = new Action<int, float, double>(AddNumber2);
            action.Invoke(50, 255.45f, 123.456);

            //CheckLengthDelegate obj3 = new CheckLengthDelegate(CheckLength);
            Predicate<string> predicate = new Predicate<string>(CheckLength);

            bool Status = predicate.Invoke("Pranaya");
            Console.WriteLine(Status);

            Console.ReadKey();
        }

        public static double AddNumber1(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }

        public static void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }

        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
    }
}