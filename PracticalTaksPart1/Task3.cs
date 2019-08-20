using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void Task()
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

    class Circle
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