using System;
using CH3.DependencyInjection;
using CH3.InversionOfControl;

namespace CH3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var program = new Program();
        }

        /// <summary>
        /// This method runs the DI Example.
        /// </summary>
        private void DependencyInject()
        {
            var logger = new TextFileLogger();
            var di = new Worker(logger);
            di.DoSomeWork(logger);
        }

        /// <summary>
        /// This method runs the IoC Exmple.
        /// </summary>
        private void InversionOfControl()
        {
            Container container = new Container();
            container.Configuration["message"] = "Hello World!";
            container.Register<ILogger>(delegate
            {
                return new TextFileLogger();
            });
            container.Register<Worker>(delegate
            {
                return new Worker(container.Create<ILogger>());
            });
        }
    }
}
