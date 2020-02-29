using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CH07_Test
{
    internal static class Program
    {
        private static List<Test> _tests;

        private static void Main(string[] args)
        {
            DisplayMainScreen();
        }

        private static void DisplayMainScreen()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Test Platform Student Console");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Press the number to do that test.");
            Console.WriteLine("[1] Reading Comprehension");
            Console.WriteLine("[2] Audio Comprehension");
            Console.WriteLine("[3] Audio Memory");
            Console.WriteLine("[4] Visual Memory");
            Console.WriteLine("[5] Counting");
            Console.WriteLine("[6] Sequencing");
            Console.WriteLine("Press 7 to exit");
            var key = Console.ReadKey();
            Process.Start(@"E:\_packtpub\Clean-Code-in-C-\CH07_Logon\bin\Debug\CH07_Logon.exe");
        }

        private static void MenuKeyPress(ConsoleKeyInfo cfi)
        {
            switch (cfi.KeyChar)
            {
                case (char)ConsoleKey.D1:
                    DoReadingComprehensionTest();
                    break;
                case (char)ConsoleKey.D2:
                    DoReadingComprehensionTest();
                    break;
                case (char)ConsoleKey.D3:
                    DoReadingComprehensionTest();
                    break;
                case (char)ConsoleKey.D4:
                    DoReadingComprehensionTest();
                    break;
                case (char)ConsoleKey.D5:
                    DoReadingComprehensionTest();
                    break;
                case (char)ConsoleKey.D6:
                    DoReadingComprehensionTest();
                    break;
                case (char)ConsoleKey.D7:
                    DoReadingComprehensionTest();
                    break;
                default:
                    break;
            }
        }

        private static void DoReadingComprehensionTest()
        {
            throw new NotImplementedException();
        }

        private static void DisplayMenu()
        {
            _tests.Add(new Test("1", "Reading Comprehension"));
            _tests.Add(new Test("1", "Reading Comprehension"));
            _tests.Add(new Test("1", "Reading Comprehension"));
            _tests.Add(new Test("1", "Reading Comprehension"));
            _tests.Add(new Test("1", "Reading Comprehension"));
            _tests.Add(new Test("1", "Reading Comprehension"));
            _tests.Add(new Test("1", "Reading Comprehension"));
        }
    }
}
