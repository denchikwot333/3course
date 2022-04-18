using System;

namespace Common.ConsoleIO
{
    static class Settings
    {
        public static void SetConsoleParam()
        {         
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
        }

    }
}
