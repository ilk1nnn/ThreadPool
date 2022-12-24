using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    #region Thread Background Example

    //public class Program
    //{

    //    static void Something()
    //    {
    //        for (int i = 0; i < 20; i++)
    //        {
    //            Console.WriteLine($"Downloading {i}");
    //            Thread.Sleep(500);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Thread thread = new Thread(() =>
    //        {
    //            Something();
    //        });
    //        thread.Start();
    //        thread.IsBackground = true;



    //        Thread thread1 = new Thread(() =>
    //        {
    //            thread.Join();
    //            for (int i = 0; i < 100; i++)
    //            {
    //                Thread.Sleep(30);
    //                Console.WriteLine("AAA");
    //            }
    //        });
    //        thread1.Start();
    //        var name = Console.ReadLine();
    //        var surname = Console.ReadLine();

    //        Console.WriteLine($"Welcome {name} {surname}");


    //        Console.WriteLine();


    //        for (int i = 0; i < 50; i++)
    //        {
    //            Console.WriteLine($"Main Downloading . . . . . . . . . . .  {i}");
    //            Thread.Sleep(20);
    //        }


    //    }
    //}



    #endregion

    #region Begin Invoke

    //public class Program
    //{

    //    delegate string SomeSpecialDelegate();



    //    public static string SomeTask()
    //    {
    //        Console.WriteLine("Some Process Going");
    //        Console.WriteLine($"Some Task ID : {Thread.CurrentThread.ManagedThreadId}");

    //        for (int i = 0; i < 10; i++)
    //        {
    //            Thread.Sleep(100);
    //            Console.WriteLine("new thread working");
    //        }


    //        return "Data";

    //    }

    //    static void Main(string[] args)
    //    {

    //        var del = new SomeSpecialDelegate(SomeTask);
    //        Console.WriteLine($"Main ThreadID : {Thread.CurrentThread.ManagedThreadId}");
    //        var ar = del.BeginInvoke(null,null);
    //        Console.WriteLine("RESULT");
    //        for (int i = 0; i < 50; i++)
    //        {
    //            Thread.Sleep(100);
    //            Console.WriteLine("Main Working");

    //        }
    //        var result = del.EndInvoke(ar);

    //    }
    //}



    #endregion

    #region ThreadPool

    //public class Program
    //{
    //    static void AsyncOperation(object state)
    //    {
    //        Console.WriteLine(state.ToString());
    //        Thread.Sleep(5000);
    //        Console.WriteLine($"ID : {Thread.CurrentThread.ManagedThreadId}");
    //    }

    //    static void Main(string[] args)
    //    {
    //        //ThreadPool.QueueUserWorkItem(AsyncOperation, "My Data 123");
    //        //Console.ReadLine();

    //        ThreadPool.GetMaxThreads(out int a,out int b);
    //        Console.WriteLine(a);
    //        Console.WriteLine(b);

    //    }
    //}



    #endregion


    #region MyRegion

    public class Program
    {
        static void FunctionThread()
        {
            Console.WriteLine($"ID : {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 1000; i++)
            {

            }
        }

        static void Main(string[] args)
        {
            //for (int i = 0; i < 600; i++)
            //{
            //    Thread thread = new Thread(() =>
            //    {
            //        FunctionThread();
            //    });
            //    thread.Start();
            //}

            ThreadPool.QueueUserWorkItem(FunctionThread);

        }
    }


    #endregion


}
