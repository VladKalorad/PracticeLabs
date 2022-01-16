using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Program
    {
        static void inputarr(int[,]arr, int size)
        {
            Console.WriteLine("Заполните элементы массива");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void FirstTask(int[,] arr, int size)
        {
            for (int j = 0; j != size; ++j)
            {
                int count = 0;
                for (int i = 0; i != size - 1; ++i)
                {
                    if (arr[i, j] <= arr[i+1, j])
                    {
                        break;
                    }
                    else
                    {
                        ++count;
                    }
                    if (count == size - 1)
                    {
                       Console.WriteLine(j);
                    }
                }
            }
        }
        //public static void task4(int[,] arr, int size)
        //{
        //    int[,] task2 = new int[size,size] ;
        //    int hjk = 0;
        //    for (int i = 0; i != size; ++i)
        //    {
        //        for (int j = 0; j <= hjk; ++j)
        //        {
        //            task2[i, j] = Math.Pow(arr[i, j], 2);
        //            Console.WriteLine(task2[i,j]);
        //        }
        //        if (i < size / 2)
        //        {
        //            ++hjk;
        //        }
        //        else
        //        {
        //            --hjk;
        //        }
        //    }
        //}
        public static void output(int[,] arr,int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{arr[i,j],3}");
                }
                Console.WriteLine();
            }
        }
        public static void outputarra(int[,] arrA, int size)
        {
            Console.WriteLine("Преобразованный: ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{arrA[i, j],3}");
                }
                Console.WriteLine();
            }
        }
        static public void task3(int[,]arr, int size)
        {
            int m = 1;
            for (int i = 0; i < (size / 2); i++)
            {
                for (int j = i; j < (size - i); j++)
                {
                    arr[i, j] = m;
                    m++;
                }
                for (int j = 1; j < (size - i - i); j++)
                {
                    arr[(j + i), (size - i) - 1] = m;
                    m++;
                }
                for (int j = (size - 2) - i; j >= i; j--)
                {
                    arr[(size - i) - 1, (j)] = m;
                    m++;
                }
                for (int j = ((size - i) - 2); j > i; j--)
                {
                    arr[j, i] = m;
                    m++;
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                //Console.WriteLine();
                Console.WriteLine(arr[i, size - 1]);
            }
        }
        static int maxi(int[,] arr, int size, int pointj, int pointi)
        {
            int max = arr[0, 0];
            int poz = 0;
            for (int i = 0; i != size; ++i)
            {
                if (max < arr[i, pointj])
                {
                    max = arr[i, pointj];
                    poz = i;
                }
            }
            for (int j = 0; j != size; ++j)
            {
                if (max < arr[pointi, j])
                {
                    max = arr[pointi, j];
                    poz = pointi;
                }
            }
            return poz;
        }

        static int maxj(int[,] arr, int size, int pointj, int pointi)
        {
            int max = arr[0, 0];
            int poz = 0;
            for (int i = 0; i != size; ++i)
            {
                if (max < arr[i, pointj])
                {
                    max = arr[i, pointj];
                    poz = pointj;
                }
            }
            for (int j = 0; j != size; ++j)
            {
                if (max < arr[pointi, j])
                {
                    max = arr[pointi, j];
                    poz = j;
                }
            }
            return poz;
        }

        static void fill(int[,] arr, int[,] arrA, int size)
        {
            for (int i = 0; i != size; ++i)
            {
                for (int j = 0; j != size; ++j)
                {
                    arrA[i, j] = arr[maxi(arr, size, j, i), maxj(arr, size, j, i)];
                }
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int [,] arr = new int[size, size] ;
            inputarr(arr, size);
           // FirstTask(arr, size);
            output(arr, size);
            //task4(arr, size);
            task3(arr, size);
            int[,] arrA = new int[3, 3];
          //  fill(arr, arrA, 3); 
            //outputarra(arrA, size);
            Console.ReadKey();
        }   
    }
}
