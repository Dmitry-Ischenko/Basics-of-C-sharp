﻿using System;

class Program
{
    static void Pause()
    {
        Console.ReadKey();
    }
    static void Print(string ms, int x=0, int y=0)
    {
        Console.WriteLine("{" + x + "," + y + "}", ms);
        return;
    }
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //6. * Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
        //Достаточно решить 3 задачи.Записывайте в начало программы условие и свою фамилию. 
        //Все программы создавайте в одном решении. Задания со звездочками выполняйте в том случае, если вы решили задачи без звездочек.

        Print("6. * Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).");
        Pause();
    }
}
