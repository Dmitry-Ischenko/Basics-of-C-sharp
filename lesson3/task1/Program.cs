using System;

class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
        //  б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;

        // А)
        Console.WriteLine("а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.");
        ComplexStruct complex1;
        complex1.re = 1;
        complex1.im = 1;

        ComplexStruct complex2;
        complex2.re = 2;
        complex2.im = 2;
        Console.WriteLine("Комплексное число complex1: " + complex1.ToString());
        Console.WriteLine("Комплексное число complex2: " + complex2.ToString());
        ComplexStruct result = complex1.Plus(complex2);
        Console.WriteLine("Результат сложения: " + result.ToString());
        result = complex1.Multi(complex2);
        Console.WriteLine("Результат произведения: " + result.ToString());
        result = complex1.Minus(complex2);
        Console.WriteLine("Результат вычитания: "+ result.ToString());
        Console.WriteLine("---------------------------------");

        // Б)
        Console.WriteLine("б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.");
        ComplexClass complexclass1 = new ComplexClass(1, 1);
        ComplexClass complexclass2 = new ComplexClass(2, 2);
        Console.WriteLine("Комплексное число complexclass1: " + complexclass1.ToString());
        Console.WriteLine("Комплексное число complexclass2: " + complexclass2.ToString());
        ComplexClass resultclass;
        resultclass = complexclass1.Plus(complexclass2);
        Console.WriteLine("Результат сложения: " + resultclass.ToString());
        resultclass = complexclass1.Multi(complexclass2);
        Console.WriteLine("Результат произведения: " + resultclass.ToString());
        resultclass = complexclass1.Minus(complexclass2);
        Console.WriteLine("Результат вычитания: " + resultclass.ToString());
        Console.ReadKey();
    }
}
struct ComplexStruct
{
    public double im;
    public double re;
    //  в C# в структурах могут храниться также действия над данными
    public ComplexStruct Plus(ComplexStruct x)
    {
        ComplexStruct y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }
    public ComplexStruct Minus(ComplexStruct x)
    {
        ComplexStruct y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }
    //  Пример произведения двух комплексных чисел
    public ComplexStruct Multi(ComplexStruct x)
    {
        ComplexStruct y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }
    public string ToString()
    {
        return re + "+" + im + "i";
    }
}

