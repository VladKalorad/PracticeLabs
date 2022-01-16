using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba15._15
{
    class Program
    {
        static void SameLetterAtLastWord()
        {
            // FileStream f = new FileStream("test.txt", FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter f = new BinaryWriter(new FileStream("test.txt", FileMode.Create), Encoding.Default);
            string zxc = "Начинается, как шум в животе Прятаться в мутной воде Вынырнуть в колыбельку И врастать помаленьку в панельку";
            string[] a = zxc.Split(' ', ',');
            string gg = a[a.Length - 1];
            char b = gg[0];
            byte[] arr;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Contains(b))
                {
                    Console.WriteLine(a[i]);
                    arr = Encoding.Default.GetBytes(a[i]);
                    f.Write(arr, 0, arr.Length);
                }
            }
            f.Close();
        }
        static void RemoveIconsOnNotEvenPosition()

        {
            using FileStream f = File.OpenRead($"E:\\ПрактикаЛабы\\laba15.15\\laba15.15\\bin\\Debug\\laba15\\laba15\\bin\\Debug\\test.txt");
            FileStream fn = new FileStream("E:\\ПрактикаЛабы\\laba15.15\\laba15.15\\bin\\Debug\\laba15\\laba15\\bin\\Debug\\testNew.txt", FileMode.Create, FileAccess.ReadWrite);
            byte[] arr = new byte[f.Length];
            byte[] zxc = new byte[f.Length];
            f.Read(arr, 0, arr.Length);
            string str = Encoding.UTF8.GetString(arr).ToString();
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    str = str.Replace(str[i], ' ');
                }
            }
            zxc = Encoding.Default.GetBytes(str);
            fn.Write(zxc, 0, zxc.Length);
            f.Close();
            fn.Close();
        }

        static void Main(string[] args)
        {
            SameLetterAtLastWord();
        }
    }
}
