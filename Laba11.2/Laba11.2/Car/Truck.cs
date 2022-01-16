using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
namespace Laba11._2
{
    [Serializable]
    class Truck : Car
    {
        public int weight;
        public string type;

        public Truck(int speed, string color, int year, int weight, int passager, int wheel, string type) : base(speed, color, year, passager, wheel)
        {
            this.weight = weight;
            this.type = type;
            Create += PrintA;
            Create(this, new EventArgs("Объект создан"));
        }
        public Truck() { }
    delegate void TruckEvent(object obj, EventArgs m);
    event TruckEvent Create;
    static void PrintA(object obj, EventArgs s)
    {
        Console.WriteLine(s.message);
    }
    public int Weight
        {
            get { return weight; }
            set
            {
                if (value < 1000)
                {
                    weight = value;
                }
                else { throw new FunctionsExeption(" Масса должна быть меньше 1000"); }
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
