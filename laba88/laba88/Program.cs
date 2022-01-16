using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace laba88
{
    class Program
    {
        public static bool Task1(int n)
        {
            int[] arr = new int[100];
            int j = 0;
            double sum = 0;
            int nn = n;
            while (n != 0)
            {
                arr[j++] = n % 10;
                n /= 10;
            }
            for (int i = 0; i < j; i++)
            {
                sum += Math.Pow(arr[i], j);
            }
            return sum == nn;
        }
        static double Factorial(int length)
        {
            int sum = 1;
            for (int i = 1; i <= length; i++)
            {
                sum *= i;
            }
            return sum;
        }
        public static void Task2()
        {
            Console.WriteLine("Введите размер последовательности: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double y = 1;
            for(int i = 1; i < n; ++i)
            {
                y += Math.Pow(-1, i) * ((Math.Pow(i, 2) + 1) / (Factorial(i * 2)));
            }
            Console.WriteLine(y);
        }
        public static void Task3()
        {
            double y = 0;
            for(double x =-2; x < 3 ;x+=0.5)
            {
                if(x > 1.5)
                {
                    y = (2 * Math.Pow(x, 3)) + 30;
                    Console.WriteLine($"x > 1.5: Y = {y}");
                }
                if(x >= 0 || x <= 1.5)
                {
                    y = x - 2;
                    Console.WriteLine($"x >= 0 || x <= 1.5: Y = {y}");
                }
                if(x < 0)
                {
                    y = Math.Pow(x, 5);
                    Console.WriteLine($"x < 0: Y = {y}");
                }
            }
        }
        public static void Task4()
        {
            double sum = 0;
            double mul = 1;
            double[] arr = new double[5];
            int Max = Array.IndexOf(arr, Math.Abs(arr.Max()));
            int min = Array.IndexOf(arr, Math.Abs(arr.Min()));
            for (int i = 1; i < arr.Length; ++i)
            {
                arr[i] = i;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }  
            for(int j = min; j < Max;++j)
            {
                mul *= arr[j];
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine($"Произведение:{mul}");
            Console.WriteLine($"Сумма:{sum}");
        }
        public static void Task5()
        {
            string a = Console.ReadLine();
            char[] abc = a.ToCharArray();
            int count = 0;
            char x = 'x';
            char y = 'y';
            for (int i = 0; i < abc.Length; i++)
            {
                if(x==abc[i] || y==abc[i])
                {
                    ++count;
                }
            }
            Console.WriteLine(count);

        }
        static bool Task6()
        {
            string s = Console.ReadLine();
            Regex regex = new Regex(@"[0-9]{1,}");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
           // Console.WriteLine(Task1(153));
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            Console.WriteLine(Task6());
            Console.ReadKey();
        }
    }
}
