using System;
using System.Collections.Generic;
using System.Text;

namespace laba11._1
{
    class Train : Carrier
    {
        public Train(int newSpeed, int newCount, int newPrice) : base(newPrice, newSpeed, newCount)
        {
        }
        public Train() : base()
        {
        }
        public override int PriceOf()
        {
            return CountOfPassangers * PricePerPassanger;
        }
        public override int TimeOf()
        {
            Console.WriteLine("Введите рассчтояние на которое будет совершена перевозка:");
            int range = Convert.ToInt32(Console.ReadLine());
            return range / Speed;
        }
        public override void Show()
        {
            Console.WriteLine("Скрость поезда равна: " + Speed);
            Console.WriteLine("Цена за место равна: " + PricePerPassanger);
            Console.WriteLine("Колличество занятых мест: " + CountOfPassangers);
        }
    }
}

