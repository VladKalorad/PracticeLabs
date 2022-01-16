using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba15
{
    public class Trapezoid
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double r;
        public Trapezoid(double a, double b, double c, double d, double r)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.r = r;
        }
        public Trapezoid(){}
        public double A
        {
            get { return a; }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    throw new FunctionsExeption("Числа должны быть больше 0");
                }
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    throw new FunctionsExeption("Числа должны быть больше 0");
                }
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
                else
                {
                    throw new FunctionsExeption("Числа должны быть больше 0");
                }
            }
        }
        public double D
        {
            get { return d; }
            set
            {
                if (value > 0)
                {
                    d = value;
                }
                else
                {
                    throw new FunctionsExeption("Числа должны быть больше 0");
                }
            }
        }
        public double R
        {
            get { return r; }
            set
            {
                if (value > 0)
                {
                    r = value;
                }
                else
                {
                    throw new FunctionsExeption("Числа должны быть больше 0");
                }
            }
        }
        public void Perimetr()
        {
            double p = a + b + c + d;
            Console.WriteLine($"Периметр: {p}");
        }
        public void Square()
        {
            double s = (1.0 / 2.0) * (a + b) * (r * 2.0);
            Console.WriteLine($"Площадь: {s}");
        }
        public void Input()
        {
            Console.WriteLine("Введите сторону A: ");
            A = Convert.ToDouble(Console.ReadLine());
            if (A < 0) throw new FunctionsExeption(" Числа должны быть больше 0");
            Console.WriteLine("Введите сторону B: ");
            B = Convert.ToDouble(Console.ReadLine());
            if (B < 0) throw new FunctionsExeption(" Числа должны быть больше 0");
            Console.WriteLine("Введите сторону C: ");
            C = Convert.ToDouble(Console.ReadLine());
            if (C < 0) throw new FunctionsExeption(" Числа должны быть больше 0");
            Console.WriteLine("Введите сторону D: ");
            D = Convert.ToDouble(Console.ReadLine());
            if (D < 0) throw new FunctionsExeption(" Числа должны быть больше 0");
            Console.WriteLine("Введите сторону R: ");
            R = Convert.ToDouble(Console.ReadLine());
            if (R < 0) throw new FunctionsExeption(" Числа должны быть больше 0");
        }
    }
}
