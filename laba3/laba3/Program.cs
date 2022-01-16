using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Program
    {
        public static void task1()
        {
            Console.WriteLine("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > 0; i /= 10)
            {
                int count = 0;
                for (int j = n; j > 0; j /= 10)
                {
                    if (i%10 == j%10)
                    {
                        ++count; 
                    }
                }
                if(count>k)
                {
                    Console.WriteLine("Содержит число") ;
                    break;
                }
            }
        }
        
        static void task2()
        {
            double a = 2.5;
            double answer = 0;
            for (double x = 1; x < 5; x += 0.5)
            {
                if (x > a)
                {
                    Console.WriteLine($"Ветвь при х>a = {answer}");
                    answer = (Math.Pow(x, 3) * Math.Sqrt(x - a));
                }
                if (x == a)
                {
                    Console.WriteLine($"Ветвь при х=a = {answer}");
                    answer = x * Math.Sin(a) * x;
                }
                else
                {
                    Console.WriteLine($"Ветвь при х<=1 = {answer}");
                    answer = Math.Exp(-a * x) * Math.Cos(a) * x;
                }
            }
            Console.ReadLine();
        }
        public static void task3()
        {
            Console.WriteLine("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                if (n % i == 0)
                {
                    if (m % i == 0)
                    {
                        Console.WriteLine(i * i);
                        break;
                    }
                }
            } 
        }
        public static void task4()
        {
            double k = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;
            int celloe = (int)k;
            double ves = k - celloe;
            int f = (int)(ves * Math.Pow(10, n));
            while (f > 0)
            {

                sum1 = (int)(sum1 + f % 10);
                f = f / 10;

            }
            while (k > 0)
            {

                sum2 = (int)(sum2 + k % 10);
                k = k / 10;

            }
            double mainsum = sum1 + sum2;
            Console.WriteLine(mainsum);
        }
        public static void task5()
        {
            double cicl = 0;
            double n = 2;
            for (double i = 1.0; i <= n; i++)
            {
                for (double j = 1.0; j <= i; j++)
                {
                    cicl += (i - j ) / (i + j);
                }
            }
            Console.WriteLine(cicl);
        }

        static public int task6()
        {
            Console.Write("index");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            double j = 0;
            int l;
            int count = 0;
            int p = 0;
            for (int i = 1; i <= k; i++)
            {

                j = Math.Pow(i, 3);
                Console.Write(j);
                l = Convert.ToInt32(j);
                if (l < 10)
                {
                    count++;
                    if (count == index)
                    {
                        Console.WriteLine(" ");
                        return l;
                    }

                }
                if (l > 10)
                {
                    for (; l != 0; l /= 10)
                    {


                        if (count == index)
                        {
                            Console.WriteLine(" ");
                            return p;
                        }
                        else
                        {
                            count++;
                            p = l % 10;

                        }
                    }
                }
            }
            l = 0;
            count = 0;
            p = 0;
            return 0;
        }

        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4();
            //task5();
            Console.WriteLine(task6());
            Console.ReadKey();
        }
    }
}
