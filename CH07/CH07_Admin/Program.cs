using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07_Admin
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            DisplayMainScreen();
        }

        private static void DisplayMainScreen()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Test Platform Administrator Console");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Process.Start(@"E:\_packtpub\Clean-Code-in-C-\CH07_Logon\bin\Debug\CH07_Logon.exe");
        }
    }
}
