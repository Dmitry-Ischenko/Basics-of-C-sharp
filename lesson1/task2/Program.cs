using System;


class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);
        //где m — масса тела в килограммах, h — рост в метрах
        Console.WriteLine("Урок 1, задание 2. Ввести вес и рост человека.");
        Console.WriteLine("Введите ваш рост (см):");
        int ur_height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ваш вес (кг):");
        int ur_weight = Convert.ToInt32(Console.ReadLine());
        float indexIMT = (float) ur_weight / (ur_height * ur_height);
        Console.WriteLine($"Ваш индекс массы тела равен {indexIMT:.0000} = {ur_weight} / ({ur_height} * {ur_height})");
        Console.ReadKey();
    }
}

