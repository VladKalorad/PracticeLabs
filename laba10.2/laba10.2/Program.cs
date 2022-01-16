using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10._2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Transport t2 = new Transport("Lada", 150, 2017, 2, "A");
            Transport t3 = new Transport("Lamba", 290, 2021, 2, "S1");
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            t2.Count_years();
            B x = new B(new Transport[] {  t2, t3 });
            Console.WriteLine(x.Max());
            x.Sortobject(2);
            x.SumOfKillometrs();
            Console.ReadKey();
        }   
    }
}
