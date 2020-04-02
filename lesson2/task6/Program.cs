using System;

class Program
{   
    static int ThisIsSUM(int number)
    {
        if (number >=10)
        {
            return (number % 10) + ThisIsSUM(number / 10);
        }
        else
        {
            return number;
        }
    }
    static void Main(string[] args)
    {
        //Выполнил Дмитрий Ищенко
        //Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
        //Хорошим называется число, которое делится на сумму своих цифр.
        //Реализовать подсчет времени выполнения программы, используя структуру DateTime.
        DateTime start = DateTime.Now;
        Console.WriteLine("Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.");
        int startGoodNumber = 1;
        int finishGoodNumber = 1000000000;
        //int finishGoodNumber = 1000000;
        int GoodNumber = 0;
        while (startGoodNumber <= finishGoodNumber)
        {
            if ((startGoodNumber % ThisIsSUM(startGoodNumber)) == 0)
            {
                Console.CursorLeft = 0;
                Console.Write(startGoodNumber + " ");
                GoodNumber++;
            }
            startGoodNumber++;
        }
        Console.Write("\n");
        Console.WriteLine("Количество хороших числе: " + GoodNumber);
        DateTime finish = DateTime.Now;
        Console.WriteLine("Время выполнения программы: " + (finish - start));
        Console.ReadKey();
    }
}

