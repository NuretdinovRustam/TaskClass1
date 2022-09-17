using System;

namespace Class1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Person kassir = new Person("Рустам", "Нуретдинов", "Флоритович", 35);
            kassir.PrintPerson();
            CashBox kassa = new CashBox(kassir);
            Person client = new Person("Иван", "Иванов", "Иванович", 35);







        }


    }
}
