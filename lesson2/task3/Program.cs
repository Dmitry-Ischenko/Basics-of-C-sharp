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

    static void Main(string[] args)
    {
        //Выполнил Дмитрий Ищенко
        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        Console.WriteLine("3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
        string numberInLine = "";
        int number;
        int summ=0;
        do
        {
            number = GetInt();
            if (number % 2 > 0 )
            {
                summ += number;
                numberInLine += number + " ";
            }
        }
        while (number != 0);
        Console.WriteLine($"Вы ввели нечетные числа [ {numberInLine}], сумма этих чисел равна {summ}");
        Console.ReadKey();
    }
}

