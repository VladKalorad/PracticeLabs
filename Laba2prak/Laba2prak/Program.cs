using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2prak
{
    class Program
    {
        static void task1()
        {
            Console.WriteLine("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            if(b == c && c == d) 
            {
                Console.WriteLine("Порядковый номер отличного от других чисел: 1");
            }
            if(a==c && c==d)
            {
                Console.WriteLine("Порядковый номер отличного от других чисел: 2");
            }
            if(c==a&&a==b)
            {
                Console.WriteLine("Порядковый номер отличного от других чисел: 4");
            }
            if(a==b&&b==d)
            {
                Console.WriteLine("Порядковый номер отличного от других чисел: 3");
            }
            else
            {
                Console.WriteLine("");
            }
        }
        static void task2()
        {
            Console.WriteLine("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch(x)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
                default:
                    Console.WriteLine("Число вне диапозона");
                    break;
            }


        }
        static void task3()
        {
            double z = 0;
            Console.WriteLine("Введите число X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double fx = Math.Pow(x, 2);
            double fy = Math.Pow(x, 2);
            Console.WriteLine("Введите число Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if(y/x > 0)
            {
                z = Math.Log10(y) + Math.Pow(Math.Abs(fx),1.0/y);
            }
            if (y / x < 0)
            {
                z = Math.Log10(Math.Abs(fy / x)) + Math.Pow(x - y, 3);
            }
            else
            {
                z = Math.Pow((Math.Pow(y + 6, 2) + y/x),2);
            }
            Console.WriteLine($"Функция z = {z}");
        }
        static double task4()
        {
            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение R:");
            double r = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if( x >= -10 && x <=-6)
            {
                y = -Math.Sqrt(4 - Math.Pow(x + 8, 2)) + 2;
            }
            if (x >= -6 && x <= -4)
            {
                y = 2;
            }
            if (x >= -4 && x <=0)
            {
                y = x / -2;
            }
            if (x > 0 && x < 2)
            {
                y =x/-4 ;
            }
            if (x > 2 && x < 4)
            {
                y = x - 3;
            }
            return y;
        }
        static void Main(string[] args)
        {
          //  task1();
            task2();
           
            Console.WriteLine(task4());
            task3();
            Console.ReadKey();
        }
    }
}
