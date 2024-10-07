using System.Reflection;

namespace Delegates_Demo
{
    public delegate void WorkPerformHandler(int hours, WorkType worktype);
    public delegate void CallbackMethodHandler(string message);
    public delegate void DoSomeMethodHandler(string message);
    public class Delegate_demo
    {
        static void Main1(string[] args)
        {
            Delegate_demo obj = new Delegate_demo();
            CallbackMethodHandler del2 = new CallbackMethodHandler(obj.CallbackMethod);
            //Here, I am calling the DoSomework function and I want the 
            //DoSomework function to call the delegate at some point of time
            //which will invoke the CallbackMethod method
            DoSomework(del2);

            WorkPerformHandler del1 =
                        new WorkPerformHandler(Manager_WorkPerformed);
            del1(10, WorkType.Golf);
            SomeClass obj1 = new SomeClass();
            DoSomeMethodHandler del3 = new DoSomeMethodHandler(obj1.DoSomework);
            MethodInfo Method = del3.Method;
            object Target = del3.Target;
            Delegate[] InvocationList = del3.GetInvocationList();
            Console.WriteLine($"Method Property: {Method}");
            Console.WriteLine($"Target Property: {Target}");

            foreach (var item in InvocationList)
            {
                Console.WriteLine($"InvocationList: {item}");
            }


            Console.ReadKey();

        }
        public static void Manager_WorkPerformed(int workHours, WorkType wType)
        {
            Console.WriteLine("Work Performed by Event Handler");
            Console.WriteLine($"Work Hours: {workHours}, Work Type: {wType}");
        }
        public static void DoSomework(CallbackMethodHandler del)
        {
            Console.WriteLine("Processing some Task");
            del("Pranaya");
        }
        public void CallbackMethod(string message)
        {
            Console.WriteLine("CallbackMethod Executed");
            Console.WriteLine($"Hello: {message}, Good Morning");
        }


    }
    public class SomeClass
    {
        public void DoSomework(string message)
        {
            Console.WriteLine("DoSomework Executed");
            Console.WriteLine($"Hello: {message}, Good Morning");
        }
    }

    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }
}
