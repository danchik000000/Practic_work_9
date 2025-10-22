using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work_9
{
    internal class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 && value > 120)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    age = value;
                }
            }
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void SayHello()
        {
            Console.WriteLine($"Привет, я {name}, мне {age} лет»");

        }
    }
}
