using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    class Program
    {
        struct Student
        {
            public string name;
            public int number;
            public int[] arr;


            public Student(string name, int number, int[] arr)
            {
                this.name = name;
                this.number = number;
                this.arr = arr;
            }

            public void PrintSec()
            {
                Console.WriteLine($"Фамилия:{name}, Номер группы: {number}, успеваемость: ");
                for (int i = 0; i < arr.Length; ++i)
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }
        static void Input(Student[] student)
        {

            double count = 0;
            for (int i = 0; i != student.Length; ++i)
            {
                Console.WriteLine("Введите Фамилию: ");
                student[i].name = Console.ReadLine();
                Console.WriteLine("Введите номер группы: ");
                student[i].number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите успеваемость: ");
                student[i].arr = new int[5];
                for (int j = 0; j != 5; j++)
                {
                    student[i].arr[j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void Sortirovka(Student[] student)
        {
            for (int i = 0; i != student.Length; i++)
            {
                for (int j = i + 1; j != student.Length; j++)
                {
                    if (student[i].number > student[j].number)
                    {
                        Student temp = student[i];
                        student[i] = student[j];
                        student[j] = temp;
                    }
                }
            }
        }
        static double Afirm(Student student)
        {
            int sum = 0;

            for (int i = 0; i != student.arr.Length; i++)
            {
                sum += student.arr[i];
            }
            return sum / student.arr.Length;
        }
        static void Print(Student[] student)
        {
            bool f = false;
            for (int i = 0; i != student.Length; i++)
                if (Afirm(student[i]) >= 4.0)
                {
                    student[i].PrintSec();
                    f = true;
                }

            if (!f) { Console.WriteLine("Нет студентов"); }
        }

        static void Main(string[] args)
        {
            Student[] st = new Student[5];
            Input(st);
            Sortirovka(st);
            Print(st);
            Console.ReadLine();
        }
    }
}
