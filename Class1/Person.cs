using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Person
    {
        private string name;
        private string surname;
        private string patronymic;
        private int age;

        //Конструктор без параметров, устанавливающий значения свойство по умолчанию.
        public Person() { name = "Имя"; surname = "Фамилия"; patronymic = "Отчество"; age = 25; }
        //Конструктор с 4 параметрами строка, строка, строка, число, для инициализации полей(имя, фамилия, отчество, возраст) класса.
        public Person(string n, string s, string p, int a) { name = n; surname = s; patronymic = p; age = a; }
        //Метод для установки возраста персоны, с проверкой на правильность ввода(возраст >= 0 и <= 200 )
        public void ChangeAge(int years)
        {
            if (years >= 0 | years <= 200)
            {
                age = years;
            }
        }
        //Метод для установки имени персоны, проверять длину строки.
        public void ChangeName(string nam)
        {
            if (nam.Length <= 19)
                name = nam;
            else
                Console.WriteLine("Имя не должно содержать больше 20 символов");
        }
        //Метод для установки фамилии персоны, проверять длину строки.
        public void ChangeSurname(string surnam)
        {
            if (surnam.Length <= 19)
                surname = surnam;
            else
                Console.WriteLine("Фамилия не должна содержать больше 20 символов");
        }
        //Метод для установки отчества персоны, проверять длину строки.
        public void ChangePatronymic(string patron)
        {
            if (patron.Length <= 19)
                patronymic = patron;
            else
                Console.WriteLine("Отчество не должно содержать больше 20 символов");
        }
        //Метод для получения возраста персоны.
        public int GetAge()
        {
            return age;
        }
        //Метод для получения имени персоны.
        public string GetName()
        {
            return name;
        }
        //Метод для получения фамилии персоны.
        public string GetSurname()
        {
            return surname;
        }
        //Метод для получения отчества персоны.
        public string GetPatronymic()
        {
            return patronymic;
        }
        //Метод вывода информации о персоне на экран.
        public void PrintPerson()
        {
            Console.WriteLine($"Возраст: {age}, Имя: {name}, Фамилия: {surname}, Отчество: {patronymic}");
        }


    }
}
