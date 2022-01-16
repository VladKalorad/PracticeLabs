using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10
{
    class Triangle
    {  
        private int a;
        private int b;
        private int c;
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int A
        {
            get
            {
                return a;
            }

            private set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }

            private set
            {
                b = value;
            }
        }
        public int C
        {
            get
            {
                return c;
            }

            private set
            {
                c = value;
            }
        }
        public void Print()
        {
            Console.WriteLine($"Сторона а: {a}, Сторона b:{b},Сторона c:{c}");
        }
        public void Perimetr()
        {
            Console.WriteLine($"Переметр: {a + b + c}");
        }
        public void Square()
        {
            double polp = (a + b + c) / 2;
            double s = Math.Sqrt(polp * (polp - a) * (polp - b) * (polp - c));
            Console.WriteLine($"Площадь: {s}");
        }
        public void Regzist()
        {
            if (a + b > c)
            {
                Console.WriteLine("Треугольник существует");
            }
            else if (b + c > a)
            {
                Console.WriteLine("Треугольник существует");
            }
            else if (a + c > b)
            {
                Console.WriteLine("Треугольник существует");
            }
            else
            {
                Console.WriteLine("Не существует");
            }
        }
    }
}
