using System;

namespace Task3_1
{
    delegate double DelegateConvertTemperature(double d);

    class TemperatureConvertImp
    {
        public double ConvertCelsiusToFahrenheit(double t) => (t - 32) * 1.8;
        public double ConvertFahrenheitToCelsius(double t) => (t + 32) / 1.8;
        
    }

    static class StaticTempConverters
    {
        public static double ConvertCelsiusToKelvin(double t) => t + 273.15;
        public static double ConvertKelvinToCelsius(double t) => t - 273.15;
        public static double ConvertCelsiusToRankine(double t) => (t + 273.15) * 1.8;
        public static double RankinRankineToCelsius(double t) => (t - 273.15) / 1.8;
        public static double ConvertCelsiusToReaumur(double t) => t*0.8;
        public static double RankinReaumurToCelsius(double t) => t*1.2;
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            TemperatureConvertImp tci = new TemperatureConvertImp();
            DelegateConvertTemperature ctf = new DelegateConvertTemperature(tci.ConvertCelsiusToFahrenheit);
            DelegateConvertTemperature ftc = new DelegateConvertTemperature(tci.ConvertFahrenheitToCelsius);
            Console.WriteLine(ctf(100));
            Console.WriteLine(ftc(100));
            DelegateConvertTemperature[] converters = new DelegateConvertTemperature[4];
            converters[0] = new DelegateConvertTemperature(tci.ConvertCelsiusToFahrenheit);
            converters[1] = new DelegateConvertTemperature(StaticTempConverters.ConvertCelsiusToKelvin);
            converters[2] = new DelegateConvertTemperature(StaticTempConverters.ConvertCelsiusToRankine);
            converters[3] = new DelegateConvertTemperature(StaticTempConverters.ConvertCelsiusToReaumur);
            string[] scales = new string[4];
            scales[0] = "Fahrenheit";
            scales[1] = "Kelvin";
            scales[2] = "Rankine";
            scales[3] = "Reaumur";
            Console.Write("Write the temperature in Celcius: ");
            double d;
            string s= Console.ReadLine();
            while (!double.TryParse(s, out d))
            {
                Console.WriteLine();
                Console.WriteLine("Incorrect input!");
                Console.Write("Write the temperature in Celcius: ");
                s = Console.ReadLine();
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Celsius to {scales[i]}: {converters[i](d)}");
            }


        }
    }
}