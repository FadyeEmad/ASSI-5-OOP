
using ASSI_5_OOP;
#region part1

//    internal class point : IComparable
//    {
//        int x, y, z;

//        public point()
//        {

//        }
//        public point(int x, int y, int z)
//        {
//            this.x = x;
//            this.y = y;
//            this.z = z;
//        }
//        public override string ToString()
//        {
//            return $"(  {x} ,  {y} , {z} ) ";
//        }
//        public void settwopoint(int X, int Y)
//        {
//            x = X;
//            y = Y;
//        }

//        public int CompareTo(object? obj)
//        {
//            point p = (point)obj;

//            if (this.x > p.x && this.y > p.y)
//            {
//                return 1;
//            }
//            else if (this.x < p.x && this.y < p.y)
//            {
//                return -1;
//            }
//            else
//            {
//                return 0;
//            }
//       }
//}


Console.WriteLine("enter p1");
int m = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());
point p1 = new point(m, k, l);
Console.WriteLine("enter p2");
m = int.Parse(Console.ReadLine());
k = int.Parse(Console.ReadLine());
l = int.Parse(Console.ReadLine());
point p2 = new point(m, k, l);

Console.WriteLine(p1.ToString());
Console.WriteLine(p2.ToString());
if (p2 == p1)
{
    Console.WriteLine("p2 = p1");
}
else
{
    Console.WriteLine("p2 != p1");
}

point[] arr = new point[5];
arr[0] = new point(40, 30, 60);
arr[1] = new point(30, 10, 55);
arr[2] = new point(90, 75, 25);
arr[3] = new point(10, 30, 80);
arr[4] = new point(70, 90, 15);
#endregion

#region part 2
//internal static class math
//{
//    public static int Add(int x, int y)
//    {
//        return x + y;
//    }

//    public static int Subtract(int x, int y)
//    {
//        return x - y;
//    }

//    public static int Multiply(int x, int y)
//    {
//        return x * y;
//    }

//    public static int Divide(int x, int y)
//    {
//        return x / y;
//    }

//}
Console.WriteLine(math.Add(10, 20));
Console.WriteLine(math.Multiply(10, 20));
Console.WriteLine(math.Subtract(10, 20));
Console.WriteLine(math.Divide(10, 20));

#endregion

#region part 3
//internal class duration
////{
//    public int Hours { get; set; }
//    public int Minutes { get; set; }
//    public int Seconds { get; set; }
//    public duration()
//    { }
//    public duration(int hours, int minutes, int seconds)
//    {
//        Hours = hours;
//        Minutes = minutes;
//        Seconds = seconds;
//    }
//    public override string ToString()
//    {
//        return $" hours {Hours} ,Minutes {Minutes} , Seconds {Seconds}";
//    }
//    public override bool Equals(object? obj)
//    {
//        return base.Equals(obj);
//    }
//    public override int GetHashCode()
//    {
//        return base.GetHashCode();
//    }
//    public static duration operator +(duration d1, duration d2)
//    {
//        duration d3 = new duration();
//        d3.Hours = d1.Hours + d2.Hours;
//        d3.Seconds = d1.Seconds + d2.Seconds;
//        d3.Minutes = d1.Minutes + d2.Minutes;
//        return d3;
//    }
//    public duration(double m)
//    {
//        if (m == 3600)
//        {
//            Hours = 1;
//            Minutes = 0;
//            Seconds = 0;
//        }
//        else if (m > 3600)
//        {
//            int integer = 0;
//            double Decimal = 0;
//            while (m > 60)
//            {
//                m = m / 60;
//            }
//            integer = (int)m;
//            Decimal = (m - integer) * 60;
//            Hours = integer;
//            Minutes = (int)(Decimal + 1);
//        }
//        else if (m < 3600)
//        {
//            int integer = 0;
//            double Decimal = 0;
//            while (m > 60)
//            {
//                m = m / 60;
//            }
//            integer = (int)m;
//            Decimal = (m - integer) * 60;
//            Minutes = integer;
//            Seconds = (int)(Decimal + 1);
//        }
//    }
//    public static duration operator +(int m, duration d1)
//    {
//        duration d2 = new duration();
//        if (m == 3600)
//        {
//            d2.Hours = 1;
//            d2.Minutes = 0;
//            d2.Seconds = 0;
//        }
//        else if (m > 3600)
//        {
//            int integer = 0;
//            double Decimal = 0;
//            while (m > 60)
//            {
//                m = m / 60;
//            }
//            integer = (int)m;
//            Decimal = (m - integer) * 60;
//            d2.Hours = integer;
//            d2.Minutes = (int)(Decimal + 1);
//        }
//        else if (m < 3600)
//        {
//            int integer = 0;
//            double Decimal = 0;
//            while (m > 60)
//            {
//                m = m / 60;
//            }
//            integer = (int)m;
//            Decimal = (m - integer) * 60;
//            d2.Minutes = integer;
//            d2.Seconds = (int)(Decimal + 1);
//        }
//        d2.Hours = d1.Hours + d2.Hours;
//        d2.Seconds = d1.Seconds + d2.Seconds;
//        d2.Minutes = d1.Minutes + d2.Minutes;
//        return d2;
//    }
//    public static duration operator +(duration d1, int m)
//    {
//        duration d2 = new duration();
//        if (m == 3600)
//        {
//            d2.Hours = 1;
//            d2.Minutes = 0;
//            d2.Seconds = 0;
//        }
//        else if (m > 3600)
//        {
//            int integer = 0;
//            double Decimal = 0;
//            while (m > 60)
//            {
//                m = m / 60;
//            }
//            integer = (int)m;
//            Decimal = (m - integer) * 60;
//            d2.Hours = integer;
//            d2.Minutes = (int)(Decimal + 1);
//        }
//        else if (m < 3600)
//        {
//            int integer = 0;
//            double Decimal = 0;
//            while (m > 60)
//            {
//                m = m / 60;
//            }
//            integer = (int)m;
//            Decimal = (m - integer) * 60;
//            d2.Minutes = integer;
//            d2.Seconds = (int)(Decimal + 1);
//        }
//        d2.Hours = d1.Hours + d2.Hours;
//        d2.Seconds = d1.Seconds + d2.Seconds;
//        d2.Minutes = d1.Minutes + d2.Minutes;
//        return d2;
//    }
//    public static duration operator ++(duration d1)
//    {
//        d1.Minutes += 1;
//        return d1;
//    }
//    public static duration operator --(duration d1)
//    {
//        d1.Minutes -= 1;
//        return d1;
//    }
//    public static duration operator -(duration d1, duration d2)
//    {
//        duration d3 = new duration();
//        if (d1.Hours > d2.Hours)
//        { d3.Hours = d1.Hours - d2.Hours; }
//        else
//        { d3.Hours = d2.Hours - d1.Hours; }
//        if (d1.Minutes > d2.Minutes)
//        { d3.Minutes = d1.Minutes - d2.Minutes; }
//        else
//        { d3.Minutes = d2.Minutes - d1.Minutes; }
//        if (d1.Seconds > d2.Seconds)
//        { d3.Seconds = d1.Seconds - d2.Seconds; }
//        else
//        { d3.Seconds = d2.Seconds - d1.Seconds; }
//        return d3;
//    }
//}
duration D1 = new duration(3600);
duration D2 = new duration(7800);
duration D3 = new duration(666);
D3 = D1 + D2;
D3 = D1 + 7800;
D3 = 666 + D3;
D3 = ++D1;
D3 = --D2;
D1 = D1 - D2;
Console.WriteLine( D1.ToString() );
#endregion