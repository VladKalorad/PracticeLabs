using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10._2
{


    class B
    {
        public Transport[] car;
         public B(Transport[]avto)
        {
            car = avto;
        }
        
        public void SumOfKillometrs()
        {
            int sum = 0;
            for(int i=0; i< car.Length;++i)
            {
                sum += car[i].speed;
            }
            Console.WriteLine($"Общая скорость автомобилей: {sum}");
        }
        public void Sortobject(int size)
        {
            Transport[] tt;

            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = car[i].speed;
            }
            Array.Sort(arr);
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (car[i].speed > car[j].speed)
                    {
                        temp = car[j].speed;
                        car[i].speed = car[j].speed;
                        car[j].speed = temp;
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(car[i].speed);
            }
        }

            public void Arifm()
        {
            double arifm = 0;
           double sum = 0;
            for (int i = 0; i < car.Length; i++)
            {
                sum += car[i].speed;
                arifm = sum / car.Length;
            }
            Console.WriteLine(arifm);
        }
        public void Sortirovka()
        {
            Array.Sort(car);
        }
        public void PrintArr()
        {
            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }
        }
        public int Max()
        {
            int Max = car[0].speed;
            for(int i = 0; i < car.Length;++i)
            { 
                if (car[i].speed > Max)
                {
                    Max = car[i].speed;
                }
            }
            Console.WriteLine("Максимальная скорость автомобилей: ");
            return Max;
        }
    }
}
