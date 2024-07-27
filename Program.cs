
using demo_oop_5.abstraction;
using demo_oop_5.operetor_overloading;
#region shapec lass
internal abstract class shape
{
    public decimal dim1 { get; set; }
    public decimal dim2 { get; set; }

    public abstract decimal calcarea();

    public abstract decimal perimeter { get; }
}

class rectangel : shape
{
    public override decimal perimeter
    {
        get { return (dim1 + dim2) * 2; }
    }

    public override decimal calcarea()
    {
        return dim1 * dim2;
    }
}
class square : shape
{
    public square(decimal dim)
    {
        dim1 = dim2 = dim;
    }
    public override decimal perimeter
    {
        get { return dim1 * 4; }
    }
    public override decimal calcarea()
    {
        return dim1 * dim2;
    }
}
#endregion
#region complex class 
internal class complex
{
    public int real { get; set; }
    public int imag { get; set; }
    public override string ToString()
    {
        return $"{real} + {imag}i";
    }
    public static complex operator +(complex a, complex b)
    {
        return new complex()
        {
            real = (a?.real ?? 0) + (b?.real ?? 0),
            imag = (a?.imag ?? 0) + (b?.imag ?? 0)
        };
    }
    public static explicit operator int(complex a)
    {
        return a?.real ?? 0;
    }

}
#endregion
#region operator overloading
//complex num = new complex();
//num.real = 45;
//num.imag = 5;
//complex num2 = new complex();
//num2.real = 30;
//num2.imag = 10;
//complex num3 = new complex();

//Console.WriteLine(num3);
#endregion
#region casting operator overloading

//int x = (int) num3;
//Console.WriteLine(x);

#endregion

#region abstraction
rectangel rec = new rectangel();
rec.dim1 = 50;
rec.dim2 = 30;
Console.WriteLine(rec.calcarea());
Console.WriteLine(rec.perimeter);
square s1 = new square(15);
Console.WriteLine(s1.perimeter);
Console.WriteLine(s1.calcarea());
#endregion