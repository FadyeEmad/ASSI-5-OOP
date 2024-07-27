using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSI_5_OOP
{
    internal class duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public duration() 
        { }
        public duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public override string ToString()
        {
            return $" hours {Hours} ,Minutes {Minutes} , Seconds {Seconds}" ;
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static duration operator + (duration d1, duration d2) 
        {
            duration d3 = new duration();
            d3.Hours = d1.Hours + d2.Hours;
            d3.Seconds = d1.Seconds + d2.Seconds;
            d3.Minutes = d1.Minutes + d2.Minutes;
            return d3;
        }
        public duration( double m)
        { 
            if (m == 3600)
            {
                Hours = 1;
                Minutes= 0;
                Seconds = 0;
            }
            else if( m > 3600)
            {
                int integer = 0;
                double Decimal = 0;
                while ( m > 60)
                {
                    m = m/ 60;
                }
                integer = (int) m;
                Decimal = (m - integer) * 60 ;
                Hours = integer;
                Minutes = (int) (Decimal + 1);
            }
            else if (m<3600)
            {
                int integer = 0;
                double Decimal = 0;
                while (m > 60)
                {
                    m = m / 60;
                }
                integer = (int)m;
                Decimal = (m - integer) * 60;
                Minutes = integer;
                Seconds = (int)(Decimal + 1);
            }
        }
        public static duration operator + (int m , duration d1)
        {
            duration d2 = new duration();
            if (m == 3600)
            {
                d2.Hours = 1;
                d2.Minutes = 0;
                d2.Seconds = 0;
            }
            else if (m > 3600)
            {
                int integer = 0;
                double Decimal = 0;
                while (m > 60)
                {
                    m = m / 60;
                }
                integer = (int)m;
                Decimal = (m - integer) * 60;
                d2.Hours = integer;
                d2.Minutes = (int)(Decimal + 1);
            }
            else if (m < 3600)
            {
                int integer = 0;
                double Decimal = 0;
                while (m > 60)
                {
                    m = m / 60;
                }
                integer = (int)m;
                Decimal = (m - integer) * 60;
                d2.Minutes = integer;
                d2.Seconds = (int)(Decimal + 1);
            }
            d2.Hours = d1.Hours + d2.Hours;
            d2.Seconds = d1.Seconds + d2.Seconds;
            d2.Minutes = d1.Minutes + d2.Minutes;
            return d2;
        }
        public static duration operator +( duration d1 , int m)
        {
            duration d2 = new duration();
            if (m == 3600)
            {
                d2.Hours = 1;
                d2.Minutes = 0;
                d2.Seconds = 0;
            }
            else if (m > 3600)
            {
                int integer = 0;
                double Decimal = 0;
                while (m > 60)
                {
                    m = m / 60;
                }
                integer = (int)m;
                Decimal = (m - integer) * 60;
                d2.Hours = integer;
                d2.Minutes = (int)(Decimal + 1);
            }
            else if (m < 3600)
            {
                int integer = 0;
                double Decimal = 0;
                while (m > 60)
                {
                    m = m / 60;
                }
                integer = (int)m;
                Decimal = (m - integer) * 60;
                d2.Minutes = integer;
                d2.Seconds = (int)(Decimal + 1);
            }
            d2.Hours = d1.Hours + d2.Hours;
            d2.Seconds = d1.Seconds + d2.Seconds;
            d2.Minutes = d1.Minutes + d2.Minutes;
            return d2;
        }
        public static duration operator ++ (duration d1)
        {
            d1.Minutes += 1;
            return d1;
        }
        public static duration operator -- (duration d1)
        {
            d1.Minutes -= 1;
            return d1;
        }
        public static duration operator -(duration d1, duration d2)
        {
            duration d3 = new duration();
            if (d1.Hours > d2.Hours)
            { d3.Hours = d1.Hours - d2.Hours; }
            else
            { d3.Hours = d2.Hours - d1.Hours; }
            if (d1.Minutes > d2.Minutes)
            { d3.Minutes = d1.Minutes - d2.Minutes; }
            else
            { d3.Minutes = d2.Minutes - d1.Minutes; }
            if (d1.Seconds > d2.Seconds)
            { d3.Seconds = d1.Seconds - d2.Seconds; }
            else
            { d3.Seconds = d2.Seconds - d1.Seconds; }
            return d3;
        }
    }
}
