using System;
using System.Collections.Generic;
using System.Text;

namespace laba11._1
{
    class Car : Carrier
    {
        double fuelPrice;
        double FuelPrice
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    fuelPrice = value;
                }
            }
            get
            {
                return fuelPrice;
            }
        }
        public Car(int newSpeed, int newCount, int newPrice, double fuel) : base(newPrice, newSpeed, newCount)
        {
            FuelPrice = fuel;
        }
        public Car() : base()
        {
            FuelPrice = 1.92;
        }
        public override int TimeOf()
        {
            Console.WriteLine("Введите рассчтояние на которое будет совершена перевозка:");
            int range = Convert.ToInt32(Console.ReadLine());
            return range / Speed;
        }
        public override int PriceOf()
        {
            return (int)(CountOfPassangers * PricePerPassanger * fuelPrice);
        }
        public override void Show()
        {
            Console.WriteLine("Скрость автомобиля равна: " + Speed);
            Console.WriteLine("Цена за место равна: " + PricePerPassanger);
            Console.WriteLine("Колличество занятых мест: " + CountOfPassangers);
            Console.WriteLine("Цена на топливо: " + fuelPrice);
        }
    }
}
