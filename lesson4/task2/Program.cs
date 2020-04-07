using System;

class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //2.Реализуйте задачу 1 в виде статического класса StaticClass;
        //  а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        //  б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
        //  в)**Добавьте обработку ситуации отсутствия файла на диске.
        int randMin = -10000;
        int randMax = 10000;
        int arrayLength = 20;
        string path = "data.txt";
        //-------------------------
        int[] a = new int[arrayLength];
        Random random = new Random();
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = random.Next(randMin, randMax);
        }
        Console.WriteLine("а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1:\n");
        Console.Write(" ответ - {0}\n", SuperClass.GetCount(a));
        Console.WriteLine("\nб) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;\n" +
            "в)**Добавьте обработку ситуации отсутствия файла на диске.\n");
        Console.Write(" ответ - {0}\n", SuperClass.GetCountInFile(path));
        Console.ReadKey();
    }
}

