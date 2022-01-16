using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_14._1
{
    class Program
    {
        public static void Task1()
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите номер: \n1. Сортировка по возрастанию \n2. Cортировка по убыванию");
            int g = Convert.ToInt32(Console.ReadLine());
            switch (g)
            {
                case 1:
                    Array.Sort(arr);
                    break;
                case 2:
                    Array.Sort(arr);
                    Array.Reverse(arr);
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Notebook nt = new Notebook(144);
            Console.WriteLine("1-Вырвать листы \n 2-Вклеить листы");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    try
                    {
                        nt.virvat();
                    }
                    catch (FunctionsExeption ex)
                    {
                        Console.WriteLine($"Исключение: {ex.Message} ");
                        Console.WriteLine($"Метод: {ex.TargetSite}");
                    }
                    break;
                case 2:
                    nt.vkleit();
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            Task1();
            Console.ReadKey();
        }
    }
}