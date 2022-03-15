using System;
using System.IO;

namespace Project2
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
          
            
        }
    }
}