using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public delegate void ResultCallbackDelegate(int result);
    public class RetriveDataFromThreadFunction
    {
        private int _number;
        private ResultCallbackDelegate _resultCallback;

        public RetriveDataFromThreadFunction(int number,ResultCallbackDelegate resultCallback)
        {
            _number = number;
            _resultCallback = resultCallback;
            
        }
        public void CalculateSum()
        {
            int res = 0;
            for(int i=0;i<5;i++)
            {
                res=res+i;
            }
            if(_resultCallback != null)
            {
                _resultCallback(res);
            }


        }


    }

    public class Program
    {
        static void Main(string[] args)
        {
            ResultCallbackDelegate resultCallbackDelegate = new ResultCallbackDelegate(ResultCallBackMethod);
            int num = 10;
            RetriveDataFromThreadFunction obj = new RetriveDataFromThreadFunction(10,resultCallbackDelegate);
            Thread thread = new Thread(new ThreadStart(obj.CalculateSum));
            thread.Start();
            Console.ReadLine();

        }
        public static void ResultCallBackMethod(int Result)
        {
            Console.WriteLine("The Result is " + Result);
        }
    }
}

