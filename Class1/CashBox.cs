using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    //клас касса, наследник от Person
    class CashBox : Person
    {
        //кассир - EmployeeCashBox
        private Person EmployeeCashBox;
        //клиент  - Client
        private Person Client;

        //конструктор кассы
        public CashBox(Person employee)
        {
            EmployeeCashBox = employee;
        }
        //Метод для установки клиента
        public void AddClient(Person client)
        {
            if (client.GetFirstName() == EmployeeCashBox.GetFirstName() & client.GetSecondName() == EmployeeCashBox.GetSecondName() & client.GetLastName() == EmployeeCashBox.GetLastName())
            {
                Console.WriteLine("фио клиента совпадает с фио кассира");
            }
            else
                Client = client;
        }
        //вывод информации о кассе: фио кассира, фио текущего клиента.
        public void PrintCashBox()
        {
            Console.WriteLine($"Кассир: {EmployeeCashBox.GetSecondName()} {EmployeeCashBox.GetFirstName()} {EmployeeCashBox.GetLastName()}\r\nКлиент: {Client.GetSecondName()} {Client.GetFirstName()} {Client.GetLastName()}");
        }
    }




}
