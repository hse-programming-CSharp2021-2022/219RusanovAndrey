using System;
using System.IO;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < 10; i++)
                {
                    binaryWriter.Write(random.Next(1,101));
                }
            }

            int[] numbers = new int[10];
            using (BinaryReader binaryReader = new BinaryReader(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = binaryReader.ReadInt32();
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();

                Console.Write("Введите число из интервала  из интервала [1;100]: ");
                int n = int.Parse(Console.ReadLine());
                while (n < 1 || n > 100)
                {
                    Console.Write("Введите число из интервала  из интервала [1;100]: ");
                    n = int.Parse(Console.ReadLine());
                }
                
                int min = 101;
                int index = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (Math.Abs(n - numbers[i]) < min)
                    {
                        min = Math.Abs(n - numbers[i]);
                        index = i;
                    }
                    
                }

                numbers[index] = n;
            }
            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < 10; i++)
                {
                    binaryWriter.Write(numbers[i]);
                }
            }
            using (BinaryReader binaryReader = new BinaryReader(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = binaryReader.ReadInt32();
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}