using System;
using System.Collections.Generic;
using System.Text;

namespace l11._1
{
    class Plane : PassengerCarrier
    {
        int comfortClass;
        bool isAirCompanyCheap;
        public int ComfortClass
        {
            set
            {
                if(value < 0 || value >2)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    comfortClass = value;
                }
            }
            get
            {
                return comfortClass;
            }
        }
        public bool IsAirCompanyCheap
        {
            set
            {
                isAirCompanyCheap = value;
            }
            get
            {
                return isAirCompanyCheap;
            }
        }
        public Plane(int newSpeed, int newCount, int newPrice,int comfort,bool cheap) : base(newPrice, newSpeed, newCount)
        {
            ComfortClass = comfort;
            IsAirCompanyCheap = cheap;
        }
        public Plane() : base()
        {
            ComfortClass = 1;
            IsAirCompanyCheap = false;
        }
        public override int TimeOf()
        {
            Console.WriteLine("Введите рассчтояние на которое будет совершена перевозка:");
            int range = Convert.ToInt32(Console.ReadLine());
            return range / Speed;
        }
        public override int PriceOf()
        {
            if(IsAirCompanyCheap)
            {
                return (int)Math.Pow(2 * (CountOfPassangers * PricePerPassanger), comfortClass);
            }
            else
            {
                return (int)Math.Pow((CountOfPassangers * PricePerPassanger), comfortClass);
            }
        }
        public override void Show()
        {
            Console.WriteLine("Скрость равна: " + Speed);
            Console.WriteLine("Цена за место равна: " + PricePerPassanger);
            Console.WriteLine("Колличество занятых мест: " + CountOfPassangers);
            Console.WriteLine("Класс комфорта: " + comfortClass);
            Console.WriteLine("Дорогая авиакомпания: " + isAirCompanyCheap);
        }
    }
}
