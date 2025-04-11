using System;
using System.Collections.Generic;

namespace IronSoftConsoleApp
{
    public static class OldPhonePadClass
    {
        static void Main(string[] args)
        {
            try
            {
                OldPhonePad();
            }
            catch (Exception e)
            {
                Console.WriteLine("Warning: " + e.Message);
                Console.Read();
            }
        }

        public static void OldPhonePad()
        {
            Console.WriteLine("Old Phone Pad Converter");
            Console.WriteLine("Type your input and press Enter. Press ESC to exit.\n");

            while (true)
            {
                Console.Write("Input: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.\n");
                    continue;
                }

                string output = OldPhonePadConverter(input);
                Console.WriteLine("Output: " + output + "\n");

                Console.WriteLine("Press any key to continue or ESC to exit.\n");

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                Console.WriteLine();
            }
        }

        public static string OldPhonePadConverter(string input)
        {
            string result = "-";

            if (!input.EndsWith("#")) Console.WriteLine("Input must end with '#'. Please check the input and try again.");
            else
            {
                // Validate and split input
                var digitGroupList = SplitIntoDigitGroups(input);

                // Map each group to characters
                result = MapCharacter(digitGroupList);
            }

            return result;
        }

        public static List<string> SplitIntoDigitGroups(string input)
        {
            // Trim whitespace 
            input = input.Trim();

            var letterList = new List<string>();
            var digitLetter = "";

            foreach (char i in input)
            {
                var eachDigit = i.ToString();

                // Case empty, assign first digit
                if (digitLetter.Length == 0) digitLetter = eachDigit;
                else
                {
                    // Case same digit, stack digitLetter
                    if (digitLetter.Contains(eachDigit)) digitLetter += eachDigit;
                    else
                    {
                        // Case different digit, add to letterList
                        if(digitLetter != " ")letterList.Add(digitLetter);
                        digitLetter = eachDigit;
                    }

                }
            }

            return letterList;
        }

        public static string MapCharacter(List<string> digitGroupList)
        {
            var result = "";
            var charactorDictionary = new Dictionary<char, string>()
            {
                {'2', "ABC"},
                {'3', "DEF"},
                {'4', "GHI"},
                {'5', "JKL"},
                {'6', "MNO"},
                {'7', "PQRS"},
                {'8', "TUV"},
                {'9', "WXYZ"}
            };

            foreach (string group in digitGroupList)
            {
                char digit = group[0];

                if (digit == '#') break; // Case '#', end mapping
                else if (digit == '*')
                {
                    if (result.Length > 0) result = result.Remove(result.Length - 1, 1); // Case '*', remove previous
                }
                else if (charactorDictionary.ContainsKey(digit))
                {
                    // Case match, find exact charactor
                    string letters = charactorDictionary[digit];
                    int digitCount = group.Length;
                    //int letterCount = letters.Length;
                    //int index = letterCount > digitCount ? digitCount : (digitCount - 1) % letters.Length; 
                    int index = (digitCount - 1) % letters.Length;
                    result = result += letters[index];
                }
            }

            return result;
        }
    }
}
