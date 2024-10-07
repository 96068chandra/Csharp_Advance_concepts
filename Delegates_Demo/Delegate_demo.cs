namespace Delegates_Demo
{
   public delegate void WorkPerformHandler(int hours,WorkType worktype);

    public class Delegate_demo
    {
        static void Main(string[] args)
        {
            WorkPerformHandler del1 =
                        new WorkPerformHandler(Manager_WorkPerformed);
            del1(10, WorkType.Golf);
            //del1.Invoke(50, WorkType.GotoMeetings);
            Console.ReadKey();
        }
        public static void Manager_WorkPerformed(int workHours, WorkType wType)
        {
            Console.WriteLine("Work Performed by Event Handler");
            Console.WriteLine($"Work Hours: {workHours}, Work Type: {wType}");
        }


    }
    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }
}
