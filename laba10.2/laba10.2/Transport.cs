using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10._2
{
    class Transport
    {
        private string firm;
        public int speed;
        private int yearsofcreate;
        protected int countofpassage;
        internal string category;

        public string Firm
        {
            get { return firm; }
            private set
            {
                if (value.Length <= 0 || value.Length > 30)
                {
                    Console.WriteLine("Неверно введено значение!");
                }
                else
                {
                    firm = value;
                }
            }
        }
        public int Speed
        {
            get { return speed; }
            private set
            {
                if (value <= 0 || value > 340)
                {
                    Console.WriteLine("Неверно введено значение!");
                }
                else
                {
                    speed = value;
                }
            }
        }
        public int YearsOfCreate
        {
            get { return yearsofcreate; }
            private set
            {
                if (value > 2021)
                {
                    Console.WriteLine("Неверно введено значение");
                }
                else
                {
                    yearsofcreate = value;
                }
            }
        }
        public int CountOfPassage
        {
            get { return countofpassage; }
            private set
            {
                if (value <= 0 || value > 80)
                {
                    Console.WriteLine("Неверно введены значения");
                }
                else
                {
                    countofpassage = value;
                }
            }
        }
        public string Category
        {
            get { return category; }
            private set
            {
                if (value.Length > 3)
                {
                    Console.WriteLine("Неверно введены значения");
                }
                else
                {
                    category = value;
                }
            }
        }
        public Transport()
        {
            Console.WriteLine("Default constructor");
        }
        public Transport(string firm, int speed, int years_of_create, int count_of_passage, string category)
        {
            Firm= firm;
            Speed = speed;
            YearsOfCreate = years_of_create;
            CountOfPassage = count_of_passage;
            Category = category;
        }
        public override string ToString()
        {
            return "Название фирмы: " + firm + " Скорость: " + speed + " Год выпуска: " + yearsofcreate + " Количество мест: " + countofpassage + " Категория: " + category;
        }
      
        public void Input()
        {
            Console.WriteLine("Введите название фирмы: ");
            firm = Console.ReadLine();
            Console.WriteLine("Введите cкорость автомобиля: ");
            speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год выпуска: ");
            yearsofcreate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество мест:  ");
            countofpassage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите категорию: ");
            category = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine("Название фирмы: " + firm + "Скорость автомобиля: " + speed + "Год выпуска: " + yearsofcreate + "Количество мест: " + countofpassage + "категория: " + category);
        }
        public void MaxSpeed()
        {
            if (speed != 340)
            {
                Console.WriteLine("Не достигнута максимальная скорость");
            }
            else
            {
                Console.WriteLine("Максимальная скорость!");
            }
        }
        public void Count_years()
        {
            int years = 2021 - yearsofcreate;
            Console.WriteLine($"Транспортному средству {years} лет");
        }
    }
}
