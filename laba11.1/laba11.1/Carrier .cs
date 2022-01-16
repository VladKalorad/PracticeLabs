using System;
using System.Collections.Generic;
using System.Text;

namespace laba11._1
{
    abstract class Carrier
    {
        int pricePerPassanger;
        int speed;
        int countOfpassangers;
        public int PricePerPassanger
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Введите корректное значение");
                }
                else
                {
                    pricePerPassanger = value;
                }
            }
            get
            {
                return pricePerPassanger;
            }
        }
        public int CountOfPassangers
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    countOfpassangers = value;
                }
            }
            get
            {
                return countOfpassangers;
            }
        }
        public int Speed
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    speed = value;
                }
            }
            get
            {
                return speed;
            }
        }
        public Carrier(int newSpeed, int newCount, int newPrice)
        {
            Speed = newSpeed;
            PricePerPassanger = newPrice;
            CountOfPassangers = newCount;
        }
        public Carrier()
        {
            PricePerPassanger = 10;
            CountOfPassangers = 2;
            Speed = 120;
        }
        public abstract int PriceOf();
        public abstract int TimeOf();
        public abstract void Show();
    }
}
