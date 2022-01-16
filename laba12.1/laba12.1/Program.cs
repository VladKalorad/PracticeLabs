using System;

namespace laba12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid pyr = new Pyramid();
            Console.WriteLine(((Foundation)pyr).Square());
            Console.WriteLine(((Foundation)pyr).Perimeter());
            Console.WriteLine(((SquareSide)pyr).SideSquare());
            Console.WriteLine(((Capacity)pyr).Capacity());
        }
    }
}
