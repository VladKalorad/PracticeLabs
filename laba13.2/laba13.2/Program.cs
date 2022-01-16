using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop s1 = new Shop("Magaz",55,76,6,"Да",7);
            Console.WriteLine(s1);
            Shop s2 = new Shop("Lol", 58, 20, 7, "Да", 10);
            Console.WriteLine(s2);
            s1.Itogsum();
            try
            {
                s1.Input();
            }
            catch (FunctionsExeption ex)
            {
                Console.WriteLine($"Исключение: {ex.Message} ");
                Console.WriteLine($"Метод: {ex.TargetSite}");
            }
        }
       
    }
}
