using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
namespace Laba11._2
{
    [Serializable]
    public class Plane : Transport
    {
        public int passager;
        public int wheel;
        public Plane(int speed, string color, int year, int wheel, int passager) : base( speed, color, year)
        {
            this.passager = passager;
            this.wheel = wheel;
            Create += PrintA;
            Create(this, new EventArgs("Объект создан"));
        }
        public Plane() { }
        delegate void PlaneEvent(object obj, EventArgs m);
        event PlaneEvent Create;
        static void PrintA(object obj, EventArgs s)
        {
            Console.WriteLine(s.message);
        }
    public int Passager
        {
            get { return passager; }
            set
            {
                if (passager < 500)
                {
                    passager = value;
                }
                else { throw new FunctionsExeption(" Пассажиров должно быть меньше"); }
            }
        }
        public int Wheel
        {
            get { return wheel; }
            set
            {
                wheel = value;
            }
        }
        public void HowManyYear()
        {
            int g = Year - 2021;
            Console.WriteLine(g);
        }
        public void Show()
        {
            Console.WriteLine($"Cкорость: {Speed}, Цвет: {Color}, Год: {Year}, Количество колес: {wheel}, Количество пассажиров: {passager}");
        }
    }
}
