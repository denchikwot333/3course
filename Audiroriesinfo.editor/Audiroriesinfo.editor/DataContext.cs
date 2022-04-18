using System.Collections;

namespace AuditoriInfo
{
    class DataContext
    {
        public static readonly ArrayList objectsList = new ArrayList();

        public static void CreateTestingData()
        {
            objectsList.AddRange(objectsArray);
        }

        static Auditori[] objectsArray = {
            new Auditori(){
                name = "ІТ",
                number = 424,
                note =" в наявності 16 ноутбуків, інтерактивна дошка але відсутній головний компьютер для показу демонстарції екрану "
            },
            new Auditori(){
                name = "Хімічна лабораторія",
                number = 12,
                note = ""
            },
        };
    }
}
