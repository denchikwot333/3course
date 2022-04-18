using Common.ConsoleIO;
using System;

namespace AuditoriInfo
{
    class Commands
    {
        public static void OutData()
        {
            Console.WriteLine(" Список аудиторій:");
            Console.WriteLine("\t№ Назва   \t\t\tНомер" +
                "\t\t Примітка ");
            for (int i = 0; i < DataContext.objectsList.Count; i++)
            {
                Auditori obj = DataContext.objectsList[i] as Auditori;
                Console.WriteLine("{0,9} {1,-30} {2,-14} {3, -10}",
                    i + 1, obj.name, obj.number, obj.note);
            }
        }

        public static void Clear()
        {
            DataContext.objectsList.Clear();
        }

        public static void Add()
        {
            Auditori inst = new Auditori();
            inst.name = Entering.EnterString("Назва аудиторії",30,4);
            inst.number = Entering.EnterInt32(
                "Номер аудиторії",1,999);
            inst.note = Entering.EnterString(
                "Примтітка",1024);
            DataContext.objectsList.Add(inst);
        }

        public static void Remove()
        {
            int number = Entering.EnterInt32("Введіть номер запису",1,DataContext.objectsList.Count);
            DataContext.objectsList.RemoveAt(number - 1);
        }

    }
}
