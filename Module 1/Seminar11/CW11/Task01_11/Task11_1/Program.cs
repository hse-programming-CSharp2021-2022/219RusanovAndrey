using System;
using System.IO;
using System.Text;
using System.Threading.Channels;

namespace ConsoleApp23
{
    class Program
    {
        public static void Print(int[] arr)
        {
            foreach (int n in arr)
            {
                Console.Write(n + "\t");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string path = @"Data.txt";

            // Создаем файл с данными
            if (File.Exists(path))
            {
                // Сейчас данные для записи вбиты в коде
                // TODO1: сохранить в файл целые случайные значения из диапазона [10;100)
                string s = Console.ReadLine();
                string createText = "";
                Random rand = new Random();
                if (int.TryParse(s, out int n))
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            createText += rand.Next(10, 100);
                        }

                        createText += Environment.NewLine;
                    }

                    File.WriteAllText(path, createText, Encoding.UTF8);
                }
            }

            // Open the file to read from
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(' ');
                int[] arr = StringArrayToIntArray(stringValues);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }

                // обрабатываем элементы массива
                // TODO2: Создать два массива по исходному
                // в первый поместить индексы чётных элементов, во второй - нечётных
                int countEven = 0;
                int countOdd = 0;
                foreach (int n in arr)
                {
                    if (n % 2 == 0)
                    {
                        countEven++;
                    }
                    else countOdd++;
                }

                int[] evens = new int[countEven];
                int[] odds = new int[countEven];
                int e = 0;
                int o = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        evens[e] = i;
                        e++;
                    }
                    else
                    {
                        odds[o] = i;
                        o++;
                    }
                    
                }
                Print(evens);
                Print(odds);
                


                // TODO3: Заменяем все нечётные числа исходного массива нулями
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        arr[i] = 0;
                    }
                }
                Print(arr);
            }
        } // end of Main()

        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str)
        {
            int[] arr = null;
            if (str.Length != 0)
            {
                arr = new int[0];
                foreach (string s in str)
                {
                    int tmp;
                    if (int.TryParse(s, out tmp))
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = tmp;
                    }
                } // end of foreach (string s in str)      
            }

            return arr;
        } // end of StringToIntArray()
    } // end of Program
}