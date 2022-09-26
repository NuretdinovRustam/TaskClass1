using System;

namespace Class1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Создать экземпляр класса Person кассир.
            Person kassir = new Person("Рустам", "Нуретдинов", "Флоритович", 35);
            //Вывести информацию о кассире на экран.
            kassir.PrintPerson();
            //Создать экземпляр класса касса.
            CashBox kass = new CashBox(kassir);
            //Создать экземпляр класса Person клиент.
            //Person client = new Person("Иван", "Иванов", "Иванович", 35);
            Person client = new Person("Рустам", "Нуретдинов", "Флоритович", 35);
            //Установить для класса касса клиента.
            kass.AddClient(client);
            kass.PrintCashBox();








        }


    }
}
