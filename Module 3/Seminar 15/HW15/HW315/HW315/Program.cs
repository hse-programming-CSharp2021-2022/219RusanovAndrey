using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        private static readonly Random Random = new();

        private static async Task<double> Integral(Func<double, double> func, int t, int k, int n)
        {
            var check = 0;
            var minX = t;
            var maxX = k;
            var maxY = (int) Math.Max(func(t), func(k)) + 1;
            for (var i = 0; i < n; i++)
            {
                await Task.Run(() =>
                {
                    if (Random.Next(0, maxY) <= func(Random.Next(minX, maxX)))
                        check++;
                });
            }
            return ((double) check / n * (maxX - minX) * maxY);
        }

        static async Task Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var list = new List<double>();
            for (var i = n; i <= k; i += 2)
            {
                await Task.Run(async() =>
                {
                    var integral = await Integral(x => x * x, i, i + 2, Random.Next(0, 100));
                    list.Add(integral);
                });
            }
            Array.ForEach(list.ToArray(), Console.WriteLine);
        }
    }
}