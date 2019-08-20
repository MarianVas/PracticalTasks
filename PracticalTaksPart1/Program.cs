using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTaks
{
    class Program
    {
        static public void Main()
        {
            ConsoleKeyInfo input;
            int taskAmount = 9;

            Console.Clear();
            Console.WriteLine("Press the correct number to chose task");

            for(int i = 1; i <= taskAmount; i++)
            {
                Console.WriteLine( i + ")Task" + i + ";");
            }

            input = Console.ReadKey();
            switch (input.Key) {
                case ConsoleKey.D1:
                    Console.Clear();
                    Task1.Program.Task();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Task2.Program.Task();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Task3.Program.Task();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Task4.Program.Task();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Task5.Program.Task();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    Task6.Program.Task();
                    break;
                case ConsoleKey.D7:
                    Console.Clear();
                    Task7.Program.Task();
                    break;
                case ConsoleKey.D8:
                    Console.Clear();
                    Task8.Program.Task();
                    break;
                case ConsoleKey.D9:
                    Console.Clear();
                    Task9.Program.Task();
                    break;
                default:
                    Main();
                    break;
            }
        }
    }
}
