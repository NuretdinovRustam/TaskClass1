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
        public void PatchAge()
        {
            int old = int.Parse(Console.ReadLine());
            if (old >= 0 | old <= 200)
            {
                age = old;
            }
        }
        //Метод для установки имени персоны, проверять длину строки.
        public void ChangeName()
        {
            string line = Console.ReadLine();
            if (line.Length <= 19)
                name = line;
            else
                Console.WriteLine("Имя не должно содержать больше 20 символов");
        }
        //Метод для установки фамилии персоны, проверять длину строки.
        public void ChangeSurname()
        {
            string line = Console.ReadLine();
            if (line.Length <= 19)
                surname = line;
            else
                Console.WriteLine("Фамилия не должна содержать больше 20 символов");
        }
        //Метод для установки отчества персоны, проверять длину строки.
        public void ChangePatronymic()
        {
            string line = Console.ReadLine();
            if (line.Length <= 19)
                patronymic = line;
            else
                Console.WriteLine("Отчество не должно содержать больше 20 символов");
        }
        //Метод для получения возраста персоны.
        public int PrintAge()
        {
            return age;
        }
        //Метод для получения имени персоны.
        public string PrintName()
        {
            return name;
        }
        //Метод для получения фамилии персоны.
        public string PrintSurname()
        {
            return surname;
        }
        //Метод для получения отчества персоны.
        public string PrintPatronymic()
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
