using System;
class Program
{
    static int GetMax(int a,int b, int c)
    {
        int maximum = a;
        if (maximum < b) maximum = b;
        if (maximum < c) maximum = c;
        return maximum;
    }
    static int GetInt(string msg="Введите число")
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
    static void Main(string[] args)
    {
        //Выполнил Дмитрий Ищенко
        //1.Написать метод, возвращающий минимальное из трех чисел.
        Console.WriteLine("1.Написать метод, возвращающий минимальное из трех чисел.");
        int a = GetInt("Введите первое число");
        int b = GetInt("Введите второе число");
        int c = GetInt("Введите третье число");
        Console.WriteLine($"Вы ввели a={a}, b={b},c={c}. Максимальное из них: "+ GetMax(a,b,c));
        Console.ReadKey();
    }
}
