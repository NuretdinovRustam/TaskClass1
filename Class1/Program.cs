using System;
using System.ComponentModel.DataAnnotations;

namespace Class1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name EmployeeCashBox");
            string nameKassir = Console.ReadLine();
            Console.WriteLine("Enter surname EmployeeCashBox");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter patronymic EmployeeCashBox ");
            string patronymic = Console.ReadLine();
            Console.WriteLine("Enter old EmployeeCashBox");
            int old = int.Parse(Console.ReadLine());
            //Создать экземпляр класса Person кассир.
            Person kassir = new Person(nameKassir, surname, patronymic, old);
            //Вывести информацию о кассире на экран.
            kassir.PrintPerson();
            //Создать экземпляр класса касса.
            CashBox kass = new CashBox(kassir);         
            Console.WriteLine("Enter name EmployeeCashBox");
            string nameClient = Console.ReadLine();
            Console.WriteLine("Enter surname EmployeeCashBox");
            string surnameClient = Console.ReadLine();
            Console.WriteLine("Enter patronymic EmployeeCashBox ");
            string patronymicCleint = Console.ReadLine();
            Console.WriteLine("Enter old EmployeeCashBox");
            int oldClient = int.Parse(Console.ReadLine());
            //Создать экземпляр класса Person клиент.
            Person client = new Person(nameClient, surnameClient, patronymicCleint, oldClient);
            //Установить для класса касса клиента.
            kass.AddClient(client);
            kass.PrintCashBox();
            client = kassir;


        }


    }
}
