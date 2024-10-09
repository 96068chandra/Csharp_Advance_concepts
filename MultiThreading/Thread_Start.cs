class Thread_Start
{
    static void Main2(string[] args)
    {
        //ThreadStart start = new ThreadStart(Displaynumber);
        //Thread thread = new Thread(start);
        //thread.Start();
        ////Using anonymous method
        //Thread thread1 = new Thread(delegate ()
        //{
        //    for (int i = 0; i < 10; i++) 
        //    {
        //        Console.WriteLine("Method 2:" + i);
        //    }

        //});
        //thread1.Start();
        ////Using lamda function
        //Thread thread2 = new Thread(() =>
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("Method 3:" + i);
        //    }

        //});
        //thread2.Start();
        int Max = 10;
        NumberHelper obj = new NumberHelper(Max);

        Thread T1 = new Thread(new ThreadStart(obj.DisplayNumbers));

        T1.Start();
        Console.Read();
        
            
    }
    public static void Displaynumber()
    {
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Method 1:"+i);
        }
    }
}
//This example used to pass the data as input to the thread 
public class NumberHelper
{
    int _Number;

    public NumberHelper(int Number)
    {
        _Number = Number;
    }

    public void DisplayNumbers()
    {
        for (int i = 1; i <= _Number; i++)
        {
            Console.WriteLine("value : " + i);
        }
    }
}