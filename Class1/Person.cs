using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Person
    {
        private string FirstName;
        private string SecondName;
        private string LastName;
        private int Age;

        public Person(string firstname, string secondname, string lastname, int age)
        {
            FirstName = firstname;
            SecondName = secondname;
            LastName = lastname;
            Age = age;
        }

        public Person()
        {
            FirstName = "No FirstName";
            SecondName = "No SecondName";
            LastName = "No LastName";
            Age = 0;
        }

        public void AddAge(int age)
        {
            if (age >= 0 & age <= 200)
                Age = age;
            else
                System.Console.WriteLine("Возраст должен быть в пределах возраст >= 0 и <= 200");
        }
        public void AddFirstName(string firstname)
        {
            if (firstname.Length <= 20)
                FirstName = firstname;
            else
                System.Console.WriteLine("Имя не должно превышать 20 символов");
        }
        public void AddLastName(string lastname)
        {
            if (lastname.Length <= 20)
                LastName = lastname;
            else
                System.Console.WriteLine("Отчестно не должно превышать 20 символов");
        }
        public void AddSecondName(string secondname)
        {
            if (secondname.Length <= 20)
                SecondName = secondname;
            else
                System.Console.WriteLine("Фамилия не должно превышать 20 символов");
        }
        public void PrintPerson()
        {
            System.Console.WriteLine($"{FirstName} {SecondName} {LastName} {Age}");
        }
        public int GetAge() => this.Age;
        public string GetFirstName() => this.FirstName;
        public string GetSecondName() => this.SecondName;
        public string GetLastName() => this.LastName;
    }
}
