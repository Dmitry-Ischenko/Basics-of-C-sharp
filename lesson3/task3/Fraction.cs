using System;
class Fraction
{
    int numerator;
    int denominator;
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }
    public Fraction(int num, int den)
    {
        numerator = num;
        if (den == 0)
        {   
            throw new ArgumentException(String.Format("Вы ввели знаменатель {0}.Знаменатель не может быть равен 0", den), "den");
        }
         denominator = den;
    }
    //Предусмотреть методы сложения, вычитания, умножения и деления дробей.
    //Сложение
    public Fraction Sum(Fraction input)
    {
        int nokGet = this.NOK(denominator, input.denominator);
        int num = numerator * nokGet / denominator + input.numerator * nokGet / input.denominator;
        Fraction sumResult = new Fraction(num, nokGet);
        return sumResult;
    }
    //вычитание
    public Fraction Sub(Fraction input)
    {
        int nokGet = this.NOK(denominator, input.denominator);
        int num = numerator * (nokGet / denominator) - input.numerator * (nokGet / input.denominator);
        Fraction sumResult = new Fraction(num, nokGet);
        return sumResult;
    }
    //Поиск наименьшее общее кратное
    private int NOK(int a,int b)
    {
        int nok = a * b;
        while (a !=0 && b !=0)
        {
            if (a > b )
            {
                a = a % b;
            }
            else
            {
                b = b % a;
            }
        }
        nok /= (a + b);
        return nok;
    }

    //умножение
    public Fraction Mult(Fraction input)
    {
        Fraction sumResult = new Fraction(numerator*input.numerator, denominator*input.denominator);
        return sumResult;
    }
    //деление
    public Fraction Div(Fraction input)
    {
        Fraction sumResult = new Fraction(numerator * input.denominator, denominator * input.numerator);
        return sumResult;
    }
    public override string ToString()
    {
        return numerator + "/" + denominator;
    }

}

