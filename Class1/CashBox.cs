using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{

    class CashBox : Person
    {
        private Person EmployeeCashBox;
        private Person Client;

        public CashBox(Person employee)
        {
            EmployeeCashBox = employee;
        }
        public void AddClient(Person client)
        {
            if (client.GetFirstName() == EmployeeCashBox.GetFirstName() & client.GetSecondName() == EmployeeCashBox.GetSecondName() & client.GetLastName() == EmployeeCashBox.GetLastName())
            {
                Console.WriteLine("фио клиента совпадает с фио кассира");
            }
            else
                Client = client;
        }
        public void PrintCashBox()
        {
            Console.WriteLine($"Кассир: {EmployeeCashBox.GetSecondName()} {EmployeeCashBox.GetFirstName()} {EmployeeCashBox.GetLastName()}\r\nКлиент: {Client.GetSecondName()} {Client.GetFirstName()} {Client.GetLastName()}");
        }
    }




}
