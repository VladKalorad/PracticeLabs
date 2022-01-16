using System;
using System.Text.RegularExpressions;
namespace laba7
{

    class Program
    {
        public static (string, string) Task1()
        {
            string str = "b1 zxc bt qeq b3e 54 gh b34", copy = str;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'b' && char.IsDigit(str[i + 1]))
                    str = str.Remove(i, 1);
            }
            return (str, new Regex(@"([a-zA-Z]){1,}").Replace(copy, ""));
        }
        public static void Task2()
        {
            string r = "Привет Ландыш Карандащ Циркуль Цирк Практика Осминог Рука Нога Вопрос";
            string[] arrrus = r.Split(' ');
            string word = "a";
            for (int i = 0; i < arrrus.Length-1; i++)
            {
                if(arrrus[i].Length <= arrrus[i+1].Length)
                {
                    word = arrrus[i];
                }
            }
            Console.WriteLine(word);
        }
        
        public static void Task3()
        {
            /*string path = "C:\\praktika.txt";
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));*/
            string str = "C:\\Program Files\\hello.txt";
            string[] arrstr = str.Split('\\');
            string a = "";
            for(int i = 0; i<arrstr.Length; ++i)
            {
                a = arrstr[i];
            }
            string[] newarr = a.Split('.');
            Console.WriteLine(newarr[0]);
        }
        public static int CountOfDot(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '!' || str[i] == '.' || str[i] == '?')
                    count++;
            }
            return count;
        }
        public static string[] FindAllSentenses(string str, string[] arrStr)
        {
            string timeStr = "";
            for (int i = 0, j = 0; i < str.Length; i++)
            {
                timeStr += str[i];
                if (str[i] == '!' || str[i] == '.' || str[i] == '?')
                {
                    arrStr[j] = timeStr;
                    j++;
                    timeStr = "";
                }
            }
            return arrStr;
        }
        public static void Task4()
        {
            string str = "Мы пойдем сегодня на рыбалку. А зачем? Потому что мы хотим половить рыбу!";
            string[] arrStr = new string[CountOfDot(str)];
            arrStr = FindAllSentenses(str, arrStr);
            var firstSent = arrStr[0].Split();
            int count = 0;
            for (int i = 0; i < firstSent.Length; i++)
            {
                for (int j = 0; j < arrStr.Length; j++)
                {
                    var timestr = arrStr[j].Split();
                    for (int k = 0; k < timestr.Length; k++)
                    { 
                        if (firstSent[i] == timestr[k])
                            count++;
                    }
                }
                if (count > 1)
                    Console.WriteLine(firstSent[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Task1());
            //Task2();
            //Task3();
            Task4();
            Console.ReadKey();
        }
    }
}
