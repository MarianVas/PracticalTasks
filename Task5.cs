using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task5
{
    class Program
    {
        public static void Task()
        {
            ConsoleKeyInfo input;

            Console.WriteLine("Chose math operation:");
            Console.WriteLine("1)Multiplication");
            Console.WriteLine("2)Division");

            input = Console.ReadKey();
            switch(input.Key)
            {
                case ConsoleKey.D1:
                    Menu(true);
                    break;
                case ConsoleKey.D2:
                    Menu(false);
                    break;
                default:
                    Task();
                    break;
            }
        }

        private static void Menu(bool temp)
        {
            double FirstReal;
            double FirstImagin;
            double SecondReal;
            double SecondImagin;
            string result = "";

            Console.Clear();

            Console.WriteLine("Enter the real part of your first complex number:");
            FirstReal = Checker();
            Console.WriteLine("Enter the imaginary part of your number:");
            FirstImagin = Checker();
            Console.WriteLine("Enter the real part of your second complex number:");
            SecondReal = Checker();
            Console.WriteLine("Enter the imaginary part of your number:");
            SecondImagin = Checker();

            if (temp)
            {

            }
            else if (!temp)
            {

            }

            Console.WriteLine("The result of multiplicating your numbers is - " + result + 'i');
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

    class ComplexNumber
    {
        public static double real;
        public static double imagin;

        #region Multiplication
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            return a;
        }
        #endregion

        #region Division
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber num = new ComplexNumber();
            Complex num1 = new Complex(real,imagin);
            return num;
        }
        #endregion
    }
}