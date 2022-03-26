using System;
using System.Collections;

namespace HW313
{
    class Fibbonacci : IEnumerable
    {
        int s = 1, n = 0, t;

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; i++)
            {
                t = s + n;
                s = n;
                yield return n = t;
            }
        }

        public IEnumerable NextMemb(int limit)
        {
            int s = 1, n = 0, t;
            for (int i = 0; i < limit; i++)
            {
                t = s + n;
                s = n;
                yield return n = t;
            }
        }
    }

    class TriangleNums
    {
        private int num = 1;

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return num;
                num += i + 2;
            }
        }

        public IEnumerable NextMemb(int limit)
        {
            for (var i = 0; i < limit; i++)
            {
                yield return this.num;
                this.num += i + 2;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Fibbonacci fi = new Fibbonacci();
            TriangleNums tri = new TriangleNums();
            int[] array = new int[10];
            int index = 0;
            foreach (var numb in fi.NextMemb(10))
            {
                Console.Write(numb + " ");
                array[index++] = (int) numb;
            }

            index = 0;
            Console.WriteLine();

            foreach (var numb in tri.NextMemb(10))
            {
                Console.Write(numb + " ");
                array[index++] += (int) numb;
            }

            Console.WriteLine();

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}