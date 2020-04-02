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
    static int GetQuantityDigitsInNumber(int Number)
    {
        int Quantity=1;
        while (true)
        {
            Number = Number / 10;
            if (Number > 0)
            {
                Quantity++;
            }
            else break;

        }
        return Quantity;
    }
    static void Main(string[] args)
    {
        //Выполнил Дмитрий Ищенко
        //2.Написать метод подсчета количества цифр числа.
        Console.WriteLine("2.Написать метод подсчета количества цифр числа.");
        int number = GetInt();
        int Quantity = GetQuantityDigitsInNumber(number);
        Console.WriteLine($"Вы ввели число {number}, оно состоит из {Quantity} цифр");
        Console.ReadKey();
    }
}

