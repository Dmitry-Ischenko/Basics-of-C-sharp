using System;
class ComplexClass
{
    double im;
    double re;
    public ComplexClass()
    {
        im = 0;
        re = 0;
    }
    public ComplexClass(double _im, double re)
    {    
        im = _im;
        this.re = re;
    }
    public ComplexClass Plus(ComplexClass x2)
    {
        ComplexClass x3 = new ComplexClass();
        x3.im = x2.im + im;
        x3.re = x2.re + re;
        return x3;
    }
    public ComplexClass Minus(ComplexClass x2)
    {
        ComplexClass x3 = new ComplexClass();
        x3.im = im - x2.im;
        x3.re = re - x2.re; 
        return x3;
    }
    //  Пример произведения двух комплексных чисел
    public ComplexClass Multi(ComplexClass x)
    {
        ComplexClass y = new ComplexClass();
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }
    public double Im
    {
        get
        {
            return im;
        }
        set
        {
            if (value >= 0) im = value;
        }
    }
    public string ToString()
    {
        return re + "+" + im + "i";
    }

}

