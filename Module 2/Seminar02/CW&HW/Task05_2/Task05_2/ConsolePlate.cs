using System;
using System.Diagnostics.SymbolStore;

namespace Task05_2
{
    public class ConsolePlate
    {
        private char _plateChar;
        private ConsoleColor _plateColor;


        public ConsolePlate()
        {
            _plateChar = '+';
            _plateColor = ConsoleColor.White;
        }

        public ConsolePlate(char symbol, ConsoleColor color)
        {
            _plateColor = color;
            _plateChar = symbol <= 31 ? '+' : symbol;
        }

        public char Symbol
        {
            get => _plateChar;
            set { _plateChar = value <= 31 ? '+' : value; }
        }

        public ConsoleColor Color { get; set; }

        public void Write()
        {
            Console.ForegroundColor = _plateColor;
            Console.Write(_plateChar);
            Console.ResetColor();
        }

        public void WriteLine()
        {
            Console.ForegroundColor = _plateColor;
            Console.WriteLine(_plateChar);
            Console.ResetColor();
        }
    }
}