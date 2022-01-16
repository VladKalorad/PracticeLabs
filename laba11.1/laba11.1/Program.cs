using System;

namespace laba11._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Carrier[] arr = new Carrier[3];
            arr[0] = new Car(120, 2, 10, 1.32);
            arr[1] = new Plain(340, 1, 500, 1, false);
            arr[2] = new Train(240, 3, 30);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Show();
                Console.WriteLine(arr[i].TimeOf());
                Console.WriteLine(arr[i].PriceOf());
            }
        }
    }
}
