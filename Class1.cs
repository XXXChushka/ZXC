using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Student
    {
        public string Name { get; set; }
        public int Kurs { get; set; }
        public string Sex { get; set; }
        public Student(string name, int kurs, string sex)
        {
            Name = name;
            Kurs = kurs;
            Sex = sex;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса Student с помощью конструктора с параметрами
            Student Student = new Student("Stas", 3, "М");

            // Выводим информацию об изделии
            Console.WriteLine("Name: " + Student.Name);
            Console.WriteLine("Kurs: " + Student.Kurs);
            Console.WriteLine("Sex: " + Student.Sex);

            // Ожидаем нажатие любой клавиши
            Console.ReadKey();
        }
    }
}
