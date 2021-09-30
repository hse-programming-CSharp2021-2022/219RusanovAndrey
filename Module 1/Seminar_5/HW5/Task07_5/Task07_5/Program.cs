using System;

namespace Task07_5
{
    class Program
    {
        public static void GCDandLCM(int a, int b, out int gcd, out int lcm)
        {
            gcd = 0;
            lcm = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                }
                
            }

            for (int i = a; i <= a*b+1; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    lcm = i;
                    break;
                    
                }
            }
        }
        
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            if (int.TryParse(s1,out int A) && int.TryParse(s2,out int B) && A >= 0 && B >= 0 )
            {
                GCDandLCM(A, B, out int GCD, out int LCM);
                Console.WriteLine("НОД: " + GCD);
                Console.WriteLine("НОК: " + LCM);
                
            }
        }
    }
}