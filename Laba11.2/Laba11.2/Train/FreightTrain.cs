﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
namespace Laba11._2
{

    [Serializable]
    class FreightTrain : Train
    {
        private int weight;
        private string type;

        public FreightTrain(int speed, string color, int year, int weight, int passager, int wheel, string type) : base(speed, color, year, passager, wheel)
        {
            this.weight = this.weight;
            this.type = this.type;
            Create += PrintA;
            Create(this, new EventArgs("Объект создан"));
        }

        delegate void FreightTrainEvent(object obj, EventArgs m);
        event FreightTrainEvent Create;
        static void PrintA(object obj, EventArgs s)
        {
            Console.WriteLine(s.message);
        }
    public int Weight
        {
            get { return weight; }
            set
            {
                if (value < 10000)
                {
                    weight = value;
                }
                else { throw new FunctionsExeption(" Масса должна быть меньше 10000"); }
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
            }
        }
        public void PriceOfTovar()
        {
            double sum = weight * 5.15;
            Console.WriteLine(sum);
        }
        public void HowManyYear()
        {
            int g = Year - 2021;
            Console.WriteLine(g);
        }
        public void Show()
        {
            Console.WriteLine($"Cкорость: {Speed}, Цвет: {Color}, Год: {Year}, Грузоподъемность: {weight}, Количество пассажиров: {Passager}, ТИп груза: {Type}");
        }
    }
}
