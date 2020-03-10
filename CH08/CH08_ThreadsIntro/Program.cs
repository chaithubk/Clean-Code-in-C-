using System;
using System.Threading;

namespace CH08_ThreadsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            SynchronousProcessing();
            ParallelProcessingUsingForegroundThreads();
            ParallelProcessingUsingBackgroundThreads();
            Console.WriteLine("***** PRESS ANY KEY TO EXIT *****");
            Console.ReadKey();
        }

        private static void SynchronousProcessing()
        {
            Method1();
            Method2();
        }

        private static void ParallelProcessingUsingForegroundThreads()
        {
            var method1Thread = new Thread(Method1);
            var method2Thread = new Thread(Method2);
            method1Thread.Start();
            method2Thread.Start();
        }

        private static void ParallelProcessingUsingBackgroundThreads()
        {
            var method3Thread = new Thread(Method3);
            method3Thread.IsBackground = true;
            method3Thread.Start();
            Console.WriteLine("Main application exited.");
        }

        private static void Method1()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method 1 Executed: {i}");
                Thread.Sleep(500);
            }
        }

        private static void Method2()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method 2 Executed: {i}");
                Thread.Sleep(500);
            }
        }

        private static void Method3()
        {
            Console.WriteLine("Method 3: Entered");
            Console.ReadKey();
            Console.WriteLine("Method 3: Exited");
        }
    }
}
