using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle abc = new Triangle(10,12,13);
            abc.Print();
            abc.Perimetr();
            abc.Square();
            abc.Regzist();
            Console.ReadKey();
        }
    }
}
