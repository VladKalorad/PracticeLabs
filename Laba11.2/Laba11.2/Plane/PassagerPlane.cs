using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
namespace Laba11._2
{
    [Serializable]
    public class PassagerPlane : Plane
    {
        public int weight;
        public PassagerPlane(int speed, string color, int year, int weight, int passager, int wheel) : base(speed, color, year, passager, wheel)
        {
            this.weight = weight;
            Create += PrintA;
            Create(this, new EventArgs("Объект создан"));
        }
        public PassagerPlane() { }
        delegate void PassagerPlaneEvent(object obj, EventArgs m);
        event PassagerPlaneEvent Create;
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
                else { throw new FunctionsExeption(" Масса должна быть меньше 1000"); }
            }
        }
        public void CountPassager()
        {
            int s = 120 - Passager;
        }
        public void HowManyYear()
        {
            int g = Year - 2021;
            Console.WriteLine(g);
        }
        public void Show()
        {
            Console.WriteLine($"Cкорость: {Speed}, Цвет: {Color}, Год: {Year}, Грузоподъемность: {weight}, Количество пассажиров: {Passager}");
        }
    }
}
