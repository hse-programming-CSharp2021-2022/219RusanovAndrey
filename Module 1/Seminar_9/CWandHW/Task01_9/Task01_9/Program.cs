using System;
using System.Diagnostics.Tracing;
using System.Text;

namespace Task01_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeiouyAEIOUY";
            string s = Console.ReadLine();
            string[] phrases = s.Split(";");
            for (int i = 0; i < phrases.Length; i++)
            {
                StringBuilder res = new StringBuilder();
                string[] words = phrases[i].Split(' ');
                for (int j = 0; j < words.Length; j++)
                {
                    words[j] = words[j].ToUpper();
                    for (int k = 0; k < words[j].Length; k++)
                    {

                        if (string.Join("", vowels).Contains(words[j][k]))
                        {
                            res.Append(words[j][k]);
                            words[j] = words[j].ToUpper();
                            break;
                        }
                        else
                        {
                            res.Append(words[j][k]);
                            words[j] = words[j].ToLower();
                        }
                    }
                }

                Console.WriteLine(res.ToString());
            }
        }
    }

}