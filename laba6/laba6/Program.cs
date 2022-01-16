using System;
using System.Linq;
namespace laba6
{
    class Program
    {
        public static void InputArr(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void Task1()
        {
            Console.WriteLine();
            Console.WriteLine("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Введите элементы массива: ");
            //InputArr(arr);
            PrintArr(arr);
            Array.Sort(arr);
        }
        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
        public static int FindMax(int[] arr)
        {
            int index = Array.IndexOf(arr, arr.Max());
            return index;
        }
        public static int FindMin(int[] arr)
        {
            int index = Array.IndexOf(arr, arr.Min());
            return index;
        }
        public static void Task2()
        {
            Console.WriteLine();
            Console.WriteLine("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Введите элементы массива: ");
            InputArr(arr);
            PrintArr(arr);
            Console.WriteLine($"\nИндекс минимального элемента:{FindMin(arr)}");
            Console.WriteLine($"Индекс максимального элемента:{FindMax(arr)}");
        }
        public static void Task3Mean(double X, double Y)
        {
            double Amean = (X + Y) / 2;
            double Gmean = Math.Sqrt(X * Y);
            Console.WriteLine($"Средне арифмитическое: {Amean}");
            Console.WriteLine($"Средне геометрическое: {Gmean}");
        }
        public static void Task4PerimnN()
        {
            int n = 3;
            double[] xx = new double[n];
            double[] yy = new double[n];
            for (int i = 0; i < n; ++i)
            {
                xx[i] = Convert.ToInt32(Console.ReadLine());
                yy[i] = Convert.ToInt32(Console.ReadLine());
            }
            double a = 0;
            a = Math.Abs(Math.Sqrt(Math.Pow(yy[1] - yy[0], 2) + Math.Pow(xx[1] - xx[0], 2)));
            Console.WriteLine($"Перемитер многоугольнкиа: {a * n}");
        }
        public static void Task5(ref double zn1, ref double zn2)
        {
            Console.WriteLine("Введите размер массива:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            double arifm = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                arifm += arr[i];
            }
            size--;
            arifm = arifm / size;
            Console.WriteLine(arifm);
            zn1 = arifm;
            zn2 = arifm;
        }
        
        static void Main(string[] args)
        {
            double zn1 = 0;
            ref double Zn1 = ref zn1;
            double zn2 = 0;
            ref double Zn2 = ref zn2;
            //Task1();
            //Task2();
            //Task3Mean(12, 24);
            //Task4PerimnN();
            Task5(ref zn1, ref zn2);
            Console.ReadKey();
        }
    }
}
