using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractacalTaskPart3
{
    class Program
    {
        static public void Main()
        {
            ConsoleKeyInfo input;
            int taskAmount = 3;

            Console.Clear();
            Console.WriteLine("Press the correct number to chose task");

            for (int i = 1; i <= taskAmount; i++)
            {
                Console.WriteLine(i + ")Task" + i + ";");
            }

            input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Task1.List.Menu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Task2.List.Menu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Task3.List.Menu();
                    break;
                default:
                    Main();
                    break;
            }
        }
    }
}
