using Common.ConsoleIO;
using System;

namespace AuditoriInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AuditoriInfo.editor (Гончарук.Д.О)";
            Settings.SetConsoleParam();
            Console.WriteLine("Використання структурованих типів");

            //StudyCommands();
            //StudyCommandInfoArray();
            Run();

            //Console.ReadKey(true);
        }

        private static void StudyCommands()
        {
            Console.WriteLine(" --- StudyCommands ---");

            Commands.OutData();
            DataContext.CreateTestingData();
            Commands.OutData();
            Commands.Add();
            Commands.OutData();
            Commands.Remove();
            Commands.OutData();
            Commands.Clear();
            Commands.OutData();
        }


        static CommandInfo[] commandInfoArray = {
            new CommandInfo("вийти", null),
            new CommandInfo("створити тестові дані", DataContext.CreateTestingData),
            new CommandInfo("додати запис...", Commands.Add),
            new CommandInfo("видалити запис...", Commands.Remove),
            new CommandInfo("видалити дані", Commands.Clear),
        };

        private static void StudyCommandInfoArray()
        {
            Console.WriteLine(" --- StudyCommandInfoArray ---");

            commandInfoArray[1].command();
            Commands.OutData();
            commandInfoArray[2].command();
            Commands.OutData();
            ShowCommandsMenu();
        }

        static void ShowCommandsMenu()
        {
            Console.WriteLine("\n Список команд меню:");
            for (int i = 0; i < commandInfoArray.Length; i++)
            {
                Console.WriteLine("\t{0,2} - {1}", i, commandInfoArray[i].name);
            }
        }

        static Command EnterCommand()
        {
            int number = Entering.EnterInt32(" Введіть номер команди меню",0,4);

            return commandInfoArray[number].command;
        }

        static void Run()
        {
            while (true)
            {
                Console.Clear();
                Commands.OutData();
                ShowCommandsMenu();
                Command command = EnterCommand();
                if (command == null)
                {
                    return;
                }
                command.Invoke();
            }
        }
    }
}