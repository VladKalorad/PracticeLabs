using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

namespace Laba11._2
{
    [Serializable]
    public class LiteCar : Car
    {
        public int passager;
        private int volume;
        public LiteCar(int speed, string color, int year, int passager, int volume, int wheel) : base(speed,color, year, wheel, passager)
        {
            this.passager = passager;
            this.volume = volume;
            Create += PrintA;
            Create(this, new EventArgs("Объект создан"));
        }
        public LiteCar()
        {

        }
        delegate void LiteCarkEvent(object obj, EventArgs m);
        event LiteCarkEvent Create;
        static void PrintA(object obj, EventArgs s)
        {
            Console.WriteLine(s.message);
        }
        public int Passager

        {
            get { return passager; }
            set
            {
                if(value < 0 || value > 9)
                {
                    passager = value;
                }
                else
                {
                    throw new FunctionsExeption(" Мест максимум 9");
                }
            }
        }
        public int Volume
        {
            get { return volume; }
            set
            {
                volume = value;
            }
        }
        public void HowManyYear()
        {
            int g = Year - 2021;
            Console.WriteLine(g);
        }
        public new void Show()
        {
            Console.WriteLine($"Cкорость: {Speed}, Цвет: {Color}, Год: {Year}, Объем двигателя:{Volume}, Количество пассажиров: {Passager}, Количество колес: {Wheel}");

        }
        public void Input()
        {
            Console.WriteLine("Введите скорость: ");

            Console.WriteLine("Введите скорость: ");
            Speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Цвет: ");
            Color = Console.ReadLine();
            Console.WriteLine("Введите год: ");
            if (Year <= 1950) throw new FunctionsExeption(" Х должен быть больше 0");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Пассажиров: ");
            Passager = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Объем: ");
            Volume = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Количество колес: ");
            Wheel = Convert.ToInt32(Console.ReadLine());

        }

    }

}
