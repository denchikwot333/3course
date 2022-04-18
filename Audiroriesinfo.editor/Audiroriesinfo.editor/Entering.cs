using System;
using System.Text.RegularExpressions;

namespace Common.ConsoleIO
{
    static class Entering
    {
        public static int EnterInt32(string prompt)
        {
            while (true)
            {
                Console.Write("\t{0}: ", prompt);
                string s = Console.ReadLine();
                int value;
                if (int.TryParse(s, out value))
                {
                    return value;
                }
                Console.WriteLine("\t\tпомилка введення цілого числа");
            }
        }
        public static int EnterInt32(string prompt,
               int min, int max = int.MaxValue)
        {
            while (true)
            {
                int value = EnterInt32(prompt);
                if (value >= min && value <= max)
                {
                    return value;
                }
                Console.WriteLine("\tПотрібно вказати значення "
                        + "в межах від {0} до {1}", min, max);
            }
        }

        public static string EnterString(string prompt)
        {
            Console.Write("\t{0}: ", prompt);
            string s = Console.ReadLine();
            s = s.Trim();
            s = RemoveDuplicateSpaces(s);
            return s;
        }

        public static string RemoveDuplicateSpaces(string s)
        {
            Regex regex = new Regex(@"\s+");
            s = regex.Replace(s, " ");
            return s;
        }
        public static string EnterString(string prompt,
                                int maxLength, int minLength = 0)
        {
            while (true)
            {
                string s = EnterString(prompt);
                if (s.Length >= minLength && s.Length <= maxLength)
                {
                    return s;
                }
                Console.WriteLine("\t\tпотрібно ввести "
                    + "від {0} до {1} символів", minLength, maxLength);
            }
        }
        public static string EnterString(string prompt, string pattern,
            string errorMessage, RegexOptions options = RegexOptions.None)
        {
            while (true)
            {
                string s = EnterString(prompt);
                if (Regex.IsMatch(s, pattern, options))
                {
                    return s;
                }
                Console.WriteLine("\t\t{0}", errorMessage);
            }
        }


    }
}
