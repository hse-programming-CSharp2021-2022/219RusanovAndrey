using System;
using System.Collections.Generic;
using System.Xml;

namespace Cinderella
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            Something[] things = new Something[n];
            for (int i = 0; i < n; i++)
            {
                int r = random.Next(0, 2);
                if (r == 0)
                {
                    things[i] = new Lentil();
                }
                else
                {
                    things[i] = new Ashes();
                }

            }

            foreach (var thing in things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine();

            List<Something> lentil = new List<Something>();
            List<Something> ashes = new List<Something>();

            for (int i = 0; i < n; i++)
            {
                if (things[i] is Lentil)
                {
                    lentil.Add(things[i]);
                }
                else ashes.Add(things[i]);
                

            }

            foreach (var l in lentil)
            {
                Console.WriteLine(l);
            }

            Console.WriteLine();
            foreach (var a in ashes)
            {
                Console.WriteLine(a);
            }

        }
    }
}