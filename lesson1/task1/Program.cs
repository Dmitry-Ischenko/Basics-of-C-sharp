using System;
class Program
{
    static void Main()
    {
        //Выполнил Ищенко Дмитрий
        //1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
        //    В результате вся информация выводится в одну строчку.
        //а) используя склеивание;
        //б) используя форматированный вывод;
        //в) *используя вывод со знаком $.
        Console.WriteLine("Урок 1, задание 1. Программа Анкета");
        Console.WriteLine("Введите ваше имя:");
        string ur_first_name = Console.ReadLine();
        Console.WriteLine("Введите вашу фамилию:");
        string ur_last_name = Console.ReadLine();
        Console.WriteLine("Введите ваш возраст:");
        int ur_age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ваш рост (см):");
        int ur_height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ваш вес (кг):");
        int ur_weight = Convert.ToInt32(Console.ReadLine());
        int salary = ur_age * ur_height * ur_weight;
        Console.WriteLine($"Здравствуйте {ur_first_name} {ur_last_name}. " +
            $"Вы указали ваш возвраст {ur_age} лет, рост {ur_height} см., и вес {ur_weight} кг. " +
            $"На основание этих данных, мы определили вашу будущую зарплату в $ {salary:.00}");
        Console.ReadKey();
    }
}

