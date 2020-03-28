using System;
class Program
{
    static double distance(int x1,int y1,int x2,int y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
        //   по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
        //   Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        //   б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
        Console.WriteLine("Урок 1, задание 3. Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2.");
        Console.WriteLine("Введите координаты первой точки");
        Console.WriteLine("Координаты X1:");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Координаты Y1:");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты второй точки");
        Console.WriteLine("Координаты X2:");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Координаты Y2:");
        int y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Между точкой ({x1},{y1}) и точкой ({x2},{y2}) растояние: " + distance(x1,y1,x2,y2));
        Console.ReadKey();

    }
}

