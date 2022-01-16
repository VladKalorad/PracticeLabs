using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
namespace Laba11._2
{
    [Serializable]
    public  class Transport 
    {
        
        public int speed;
        public string color;
        public int year;
        public Transport(int speed, string color,  int year)
        {
            this.color = color;
            this.year = year;
            this.speed = speed;
        }
        public Transport() { }
        public int Year
        {
            get { return year; }
            set
            {
                year = value;
            }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                speed = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
            }
        }
       
        public void Show()
        {
        }
        public void HowManyYear()
        { }

    }
}
