using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static public void Task()
        {
            float x1;
            float y1;
            float x2;
            float y2;

            Console.WriteLine("Enter the coordinates of the top left angle");
            Console.Write("x:");
            x1 = checker();
            Console.Write("y:");
            y1 = checker();

            Console.WriteLine("Enter the coordinates of the button right angle");
            Console.Write("x:");
            x2 = checker();
            Console.Write("y:");
            y2 = checker();

            Rectangle input = new Rectangle(x1, y1, x2, y2);

            Console.WriteLine("Your rectangle area is - " + input.Area);
            Console.WriteLine("Your rectangle perimeter is - " + input.Perimeter);
            Console.ReadKey();

            PracticalTaks.Program.Main();
        }

        static private float checker()
        {
            string value;
            float result = 0;
            bool temp = true;

            while (temp)
            {
                try
                {
                    value = Console.ReadLine();
                    result = Convert.ToSingle(value);
                    temp = false;
                }
                catch
                {
                    Console.WriteLine("Wrong data input!");
                    Console.Write(":");
                    temp = true;
                }
            }
            return result;
        }
    }

    class Rectangle
    {
        public float Perimeter { get; set; }
        public float Area { get; set; }
        
        public Rectangle(float x1, float y1, float x2, float y2)
        {
            float Lenght2;
            float Lenght1;

            Lenght1 = equal(x1, x2);
            Lenght2 = equal(y1, y2);

            Area = Lenght1 * Lenght2;
            Perimeter = Lenght1 * 2 + Lenght2 * 2;
        }

        private float equal(float n1, float n2)
        {
            float sideLenght = 0;
            if (n1 >= n2)
                sideLenght = n1 - n2;
            else if (n1 <= n2)
                sideLenght = n2 - n1;
            return sideLenght;
        }
    }
}