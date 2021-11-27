using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;

namespace Exceptions
{
    class UselessException : Exception
    {
        public UselessException() : base()
        {
        }

        public UselessException(string message) : base(message)
        {
        }

        public override string Message => "This exception is useless!";
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                int b = 0;
                int c = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Нельзя делить на ноль!");
            }

            try
            {
                int[] array = new int[3];
                array[4] = 4;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Значение индекса находится вне диапазона допустимых значений!");
            }

            try
            {
                bool flag = true;
                Char ch = Convert.ToChar(flag);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Невозможно преобразовать тип bool в char!");
            }


            try
            {
                var text = File.ReadAllLines("text");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден!");
            }

            try
            {
                string s = "string";
                int x = int.Parse(s);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат!");
            }
            try
            {
                string s = null;
                string[] array = s.Split();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Попытка обращения к объекту, который равен null!");
            }

            try
            {
                List<string> list = new List<string>();
                list.RemoveAt(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Недопустимое значение!");
            }

            try
            {
                checked
                {
                    byte b = 255;
                    sbyte s = (sbyte) b;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Переполнение при преобразовании типов!");
            }

            try
            {
                string s = "string";
                while (true)
                {
                    s += s + s + s;
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Недостаточный объём памяти!");
            }

            try
            {
                string[] names = {"George", "John", "Thomas"};
                Object[] objs = (Object[]) names;
                objs[2] = 2;
            }
            catch (ArrayTypeMismatchException)
            {
                Console.WriteLine("Несоответствие типов!");
            }

            try
            {
                throw new UselessException();
            }
            catch (UselessException)
            {
                Console.WriteLine("Бесполезное исключение.");
            }
        }
    }
}