using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static public void Task()
        {
            ConsoleKeyInfo input;

            Console.WriteLine("1)Rectangle");
            Console.WriteLine("2)Circle");

            input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    RectangleMenu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    CircleMenu();
                    break;
                default:
                    Task();
                    break;
            }
        }

        static private void CircleMenu()
        {
            double radius;
            double area;
            double circuit;

            Console.WriteLine("Enter the radius of your circle:");
            radius = Checker();

            circuit = Circle.Circuit(radius);
            area = Circle.Area(radius);

            Console.WriteLine("Your circle circuit is - " + circuit);
            Console.WriteLine("Your circle area is - " + area);

            Console.ReadKey();

            PracticalTaks.Program.Main();
        }

        static private void RectangleMenu()
        {
            double x1;
            double y1;
            double x2;
            double y2;
            double area;
            double perimeter;

            Console.WriteLine("Enter the coordinates of the top left angle");
            Console.Write("x:");
            x1 = Checker();
            Console.Write("y:");
            y1 = Checker();

            Console.WriteLine("Enter the coordinates of the button right angle");
            Console.Write("x:");
            x2 = Checker();
            Console.Write("y:");
            y2 = Checker();

            area = Rectangle.Area(x1, y1, x2, y2);
            perimeter = Rectangle.Perimeter(x1, y1, x2, y2);

            Console.WriteLine("Your rectangle area is - " + area);
            Console.WriteLine("Your rectangle perimeter is - " + perimeter);
            Console.ReadKey();

            PracticalTaks.Program.Main();
        }

        static private double Checker()
        {
            string value;
            double result = 0;
            bool temp = true;

            while (temp)
            {
                try
                {
                    value = Console.ReadLine();
                    result = Convert.ToDouble(value);
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

    static class Rectangle
    {
        static private double Lenght1;
        static private double Lenght2;

        static public double Perimeter(double x1, double y1, double x2, double y2)
        {
            double perimeter;

            Lenght1 = equal(x1, x2);
            Lenght2 = equal(y1, y2);

            return perimeter = Lenght1 * 2 + Lenght2 * 2;
        }

        static public double Area(double x1, double y1, double x2, double y2)
        {
            double area;

            Lenght1 = equal(x1, x2);
            Lenght2 = equal(y1, y2);

            return area = Lenght1 * Lenght2;
        }

        static private double equal(double n1, double n2)
        {
            double sideLenght = 0;
            if (n1 >= n2)
                sideLenght = n1 - n2;
            else if (n1 <= n2)
                sideLenght = n2 - n1;
            return sideLenght;
        }
    }

    static class Circle
    {
        private const double pi = 3.1415926535;

        static public double Area(double r)
        {
            double result;
            return result = pi * r * r;
        }

        static public double Circuit(double r)
        {
            double result;
            return result = 2 * pi * r;
        }
    }
}