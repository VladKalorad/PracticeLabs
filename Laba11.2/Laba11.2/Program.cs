using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
namespace Laba11._2
{
    class Program
    {
        
        static void Main(string[] args)
        {   
            CargoPlane c1 = new CargoPlane(123, "Black", 2020, 155, 21, 122, "Gruzovoi");
            c1.Show();
            Plane p1 = new Plane(123, "Black", 2020,8, 122);
            p1.Show();
            PassagerPlane a1 = new PassagerPlane(148, "Yelow", 2019, 100, 12, 8);
            a1.Show();
            Car avto = new Car(240,"Red",2003, 4, 5);
            avto.Show();
            LiteCar liteavto = new LiteCar(250, "Perple", 2004, 9, 240, 5);
            liteavto.Show();
            Train poezd = new Train(260,"Yellow",2003,18,220);
            poezd.Show();
            poezd.HowManyYear();
            PassagerTrain pasTrain = new PassagerTrain(360,"Yellow",2001,122,250,5.5);
            pasTrain.Show();//(int speed, string color, int year, int wheel, int passager, double price)
            pasTrain.Pricepr();
            FreightTrain ftrain = new FreightTrain(450,"Aboba",2005,155,211, 120,"Gruzovoi");
            ftrain.Show();
            TransportArray t = new TransportArray(new Transport[] { avto,liteavto });
            t.SortObject();

            LiteCar lt1 = new LiteCar(250, "Perple", 2004, 9, 240, 5);
            LiteCar lt2 = new LiteCar(240, "Red", 2007, 9, 240, 5);
            TransportArray X = new TransportArray(new List<LiteCar> { lt1, lt2});

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("transport.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, c1);
                formatter.Serialize(fs, avto);
                formatter.Serialize(fs, liteavto);
                formatter.Serialize(fs, poezd);
                formatter.Serialize(fs, pasTrain);
                formatter.Serialize(fs, ftrain);
                Console.WriteLine("Объекты сериализован");
            }
            XmlSerializer formatter3 = new XmlSerializer(typeof(Transport));
            using (FileStream fs = new FileStream("room.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, c1);
                formatter.Serialize(fs, p1);
                formatter.Serialize(fs, a1);
                formatter.Serialize(fs, avto);
                formatter.Serialize(fs, liteavto);
                formatter.Serialize(fs, poezd);
                formatter.Serialize(fs, pasTrain);
                formatter.Serialize(fs, ftrain);
                Console.WriteLine("Объект сериализован");
            }
            Console.ReadKey();
        }

    }
}
