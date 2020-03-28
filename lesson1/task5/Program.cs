using System;
class Program
{
    static void Print(string ms, int x, int y)
    {
        Console.WriteLine("{"+ x+","+y+"}", ms);
        return;
    }
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //5.
        //    а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //    б) Сделать задание, только вывод организуйте в центре экрана
        //    в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
        Console.WriteLine("Написать программу, которая выводит на экран ваше имя, фамилию и город проживания");
        Console.WriteLine("Введите ваше имя:");
        string ur_first_name = Console.ReadLine();
        Console.WriteLine("Введите вашу фамилию:");
        string ur_last_name = Console.ReadLine();
        Console.WriteLine("Введите вашу фамилию:");
        string ur_city = Console.ReadLine();
        string msg = $"Вас зовут {ur_first_name} {ur_last_name}. Ваш город {ur_city}";
        int x=0;
        int y= Console.WindowWidth/2 + msg.Length/2;
        Print(msg, x, y);
        Console.ReadKey();
    }
}

