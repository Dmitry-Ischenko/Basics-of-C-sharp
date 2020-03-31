using System;

class Program
{
    static int GetInt(string msg = "Введите число")
    {
        int number;
        bool isNumber;
        do
        {
            Console.WriteLine(msg);
            isNumber = Int32.TryParse(Console.ReadLine(), out number);
        } while (!isNumber);
        return number;
    }
    static int Interstellar(int a, int b)
    {
        if (a <b )
        {
            Console.WriteLine(a);
            return a + Interstellar(a + 1, b);
        }
        else
        {
            Console.WriteLine(b);
            return b;
        }
    }
    static void Main(string[] args)
    {
        //Выполнил Дмитрий Ищенко
        //7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b);
        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        Console.WriteLine("Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b)");
        int a;
        int b;
        do
        {
            Console.WriteLine("Введите числа A и B (А должно быть меньше B)");
            a = GetInt("Введите число А:" );
            b = GetInt("Введите число В: ");
        }
        while (a>b);
        Console.WriteLine($"Сумма чисел от {a} до {b} = " + Interstellar(a,b));
        Console.ReadKey();
    }
}
