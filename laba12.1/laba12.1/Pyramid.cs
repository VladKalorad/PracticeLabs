using System;
using System.Collections.Generic;
using System.Text;

namespace laba12._1
{
    class Pyramid : Foundation, Capacity, SquareSide
    {
        double heightfound;
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public int SideD { get; set; }
        public int SideE { get; set; }
        public int Apophem { get; set; }
        public Pyramid()
        {
            int p = (SideA + SideB + SideC) * 1 / 2;
            SideA = 4;
            SideB = 5;
            SideC = 3;
            SideD = 8;
            SideE = 9;
            Apophem = 7;
            heightfound = 2 * (Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)) / SideA);
        }
        public Pyramid(int _sideA, int _sideB, int _sideC, int _sideD, int _sideE, int _apophem)
        {
            int p = (SideA + SideB + SideC) * 1 / 2;
            SideA = _sideA;
            SideB = _sideB;
            SideC = _sideC;
            SideD = _sideD;
            SideE = _sideE;
            Apophem = _apophem;
            heightfound = 2 * (Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)) / SideA);
        }
        double Foundation.Square()
        {
            return (heightfound+2) * SideA ;
        }
        double Foundation.Perimeter()
        {
            return SideA + SideB + SideC;
        }
        double SquareSide.SideSquare()
        {
            return 0.5 * (SideA + SideB + SideC) * Apophem;
        }
        double Capacity.Capacity()
        {
            return (1.0 / 3.0) * (heightfound+2 * SideA * 1.0 / 2.0);
        }
    }
    }