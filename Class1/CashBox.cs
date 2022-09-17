using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{

    class CashBox
    {
        private Person EmployeeCashBox;
        private Person Client;

        public CashBox(Person employee)
        {
            EmployeeCashBox = employee;
        }
        public void AddClient(string firstname, string secondname, string lastname, int age)
        {
            Client.AddFirstName(firstname);

            Client.AddSecondName(secondname);
            Client.AddLastName(lastname);
            Client.AddAge(age);
            if (firstname == EmployeeCashBox.GetFirstName() & secondname == EmployeeCashBox.GetSecondName() & lastname == EmployeeCashBox.GetLastName())
            {
                Console.WriteLine("фио клиента совпадает с фио кассира");
            }
        }
        public void PrintCashBox()
        {
            Console.WriteLine($"Кассир: {EmployeeCashBox.GetFirstName()} {EmployeeCashBox.GetSecondName()} {EmployeeCashBox.GetLastName()}");
        }


    }




}
