using System;
using System.Collections.Generic;
using System.Text;

namespace RomanConverter
{
    internal class Program
    {
        private static void Main(string[] args)
        {           
            Console.WriteLine("Enter number you want to convert to roman: ");
            var input = Console.ReadLine();
            int number;

            while (!int.TryParse(input, out number) || number < 1 || number >= 4000)
            {
                Console.WriteLine("Please enter valid number: ");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Roman number is {Roman.ConvertToRoman(number)}" );
        }
    }

    public static class Roman
    {
        public static string ConvertToRoman(int numberToConvert)
        {
            var result = new StringBuilder();
            var romanDictionary = new Dictionary<string, int>
            {
                {"M", 1000},
                {"CM", 900},
                {"D", 500},
                {"CD", 400},
                {"C", 100},
                {"L", 50},
                {"XL", 40},
                {"X", 10},
                {"IX", 9},
                {"V", 5},
                {"IV", 4},
                {"I", 1}
            };

            foreach (var item in romanDictionary)
            {
                while (numberToConvert >= item.Value)
                {
                    result.Append(item.Key);
                    numberToConvert -= item.Value;
                    if (numberToConvert < 1)
                        break;
                }
            }

            return result.ToString();
        }
    }
}