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
            switch (input.Key)
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

            var value1 = new ComplexNumber(FirstReal, FirstImagin);
            var value2 = new ComplexNumber(SecondReal, SecondImagin);
            if (temp)
            {
                result = ComplexToString(value1 * value2);
            }
            else if (!temp)
            {
                result = ComplexToString(value1 / value2);
            }

            Console.WriteLine("The result of multiplicating your numbers is - " + result + 'i');
            Console.ReadKey();

            PracticalTaks.Program.Main();
        }

        static private string ComplexToString(Complex a)
        {
            string text = a.ToString();
            text = text.Trim(new char[] { '(', ')' });
            return text;
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
        private readonly double Real;
        private readonly double Imagin;
        private readonly Complex Value;

        public ComplexNumber(double real, double imagin)
        {
            Real = real;
            Imagin = imagin;
            Complex value = new Complex(Real, Imagin);
        }

        public ComplexNumber(Complex value)
        {
            Value = value;
        }

        #region Multiplication
        public static Complex operator *(ComplexNumber a, ComplexNumber b)
            =>Complex.Multiply(new Complex(a.Real,a.Imagin), new Complex(b.Real, b.Imagin));
        #endregion

        #region Division
        public static Complex operator /(ComplexNumber a, ComplexNumber b)
            => Complex.Divide(new Complex(a.Real, a.Imagin), new Complex(b.Real, b.Imagin));
        #endregion
    }
}