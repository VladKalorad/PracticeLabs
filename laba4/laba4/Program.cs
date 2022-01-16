using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Program
    {
        public static int min(int[] arr)
        {
            int minpoz = 0;
            int min = Math.Abs(arr[0]);
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > Math.Abs(arr[i]))
                {
                    min = Math.Abs(arr[i]);
                    minpoz = i;
                }
            }
            return minpoz;
        }

        public static int task1(int[] arr)
        {
            int sum = 0;
            for (int i = min(arr)+1; i < arr.Length; ++i)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static void inputtask1(int[] arr)
        {
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void task2(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    ++count;
                }
            }
            Console.Write($"Количество четных элементов: {count}");
        }
        public static void task3(int[]arr)
        {
            Console.WriteLine("Четные:");
            for (int i = 0; i < arr.Length; i+=2)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine("Нечетные:");
            for (int i = 1; i < arr.Length; i += 2)
            {
               Console.Write(arr[i]);
            }
        }
        public static void task4(int[]arr)
        {

            int min_dif = 9999999;
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) < min_dif)
                    {
                        index1 = i;
                        index2 = j;
                        min_dif = Math.Abs(arr[i] - arr[j]);
                    }
                }
            }
            Console.WriteLine("index1: " + index1 + "index2:" + index2);
        }
        public static void task5(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            { 
                Console.WriteLine(arr[i]);
            }
        }
        public static void task6(int[]arr)
        {
            int[] secondarr = new int[arr.Length * 2];
            int ofset = 0;
            int i = 0;
            for (i = 0; i < arr.Length - 1; i++)
            {
                secondarr[i + ofset] = arr[i];
                if (arr[i] != arr[i + 1]) 
                {
                    ofset++; 
                    secondarr[i + ofset] = arr[i]; 
                }
            }
            secondarr[i + ofset] = arr[i];
            ofset++;
            secondarr[i + ofset] = arr[i];
            ofset = i + ofset;
            for (i = 0; i <= ofset; i++)
            {
                Console.Write(secondarr[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива ");//первый таск
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            inputtask1(arr);
            //Console.WriteLine(task1(arr));
            //inputtask2(arr);
            //task2(arr);
            //task3(arr);
            //task4(arr);
            //task5(arr); 
            //task4(arr);
            task6(arr);
            Console.ReadKey();
        }
    }
}
