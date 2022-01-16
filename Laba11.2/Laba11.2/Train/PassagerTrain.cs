using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
namespace Laba11._2
{
    [Serializable]
    public class PassagerTrain : Train
    {
        public double price = 10.1;

        public PassagerTrain(int speed, string color, int year, int wheel, int passager, double price) : base(speed, color, year, wheel, passager)
        {
            passager = Passager;
            Create += PrintA;
            Create(this, new EventArgs("Объект создан"));
        }
        public PassagerTrain() { }
        delegate void PassagerTrainEvent(object obj, EventArgs m);
        event PassagerTrainEvent Create;
        static void PrintA(object obj, EventArgs s)
        {
            Console.WriteLine(s.message);
        }
    public void Pricepr()
        {
            double s = price * Passager;
            Console.WriteLine(s);
        }
        public void CountPassager()
        {
            int s = 198 - Passager;
            Console.WriteLine(s);
        }
        public void HowManyYear()
        {
            int g = Year - 2021;
            Console.WriteLine(g);
        }
        public void Show()
        {
            Console.WriteLine($"Cкорость: {Speed}, Цвет: {Color}, Год: {Year}, Количество колес: {Wheel}, Количество пассажиров: {Passager}");
        }
    }
}
