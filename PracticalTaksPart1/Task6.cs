using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        public static void Task()
        {
            Rectangle a = new Rectangle();
            Square b = new Square();

            a.Draw();
            b.Draw();

            Console.ReadKey();
            PracticalTaks.Program.Main();
        }
    }

    abstract class Figure
    {
        public abstract void Draw();
    }

    class Square : Figure
    {
        public override void Draw()
        {
            string className = nameof(Square);
            Console.WriteLine("This is the " + className + " class method");
        }
    }

    class Rectangle : Figure
    {
        public override void  Draw()
        {
            string className = nameof(Rectangle);
            Console.WriteLine("This is the " + className + " class method");
        }
    }
}
