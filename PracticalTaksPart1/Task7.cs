using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        public static void Task()
        {
            double x;
            double y;

            Console.WriteLine("Enter X:");
            x = Checker();
            Console.WriteLine("Enter Y:");
            y = Checker();

            Rectangle a = new Rectangle(x, y);
            Square b = new Square(x, y);

            a.Draw();
            b.Draw();

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

    abstract class Figure
    {
        public abstract void Draw();

        protected readonly double X;
        protected readonly double Y;

        protected Figure(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    class Square : Figure
    {
        public Square(double x, double y) : base(x, y) { }

        public override void Draw() 
        {
            string className = nameof(Square);
            Console.WriteLine("This is the " + className + " class method, and the value in class Figure is: X - " + X + "; Y - " + Y);
        }
    }

    class Rectangle : Figure
    {
        public Rectangle(double x, double y) : base(x, y) { }

        public override void Draw()
        {
            string className = nameof(Rectangle);
            Console.WriteLine("This is the " + className + " class method, and the value in class Figure is: X - " + X + "; Y - " + Y);
        }
    }
}
