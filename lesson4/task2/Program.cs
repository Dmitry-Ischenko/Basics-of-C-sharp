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
        int[] a;
        StaticClass.FillArray(out a,randMin, randMax, arrayLength);
        Console.WriteLine("а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1:\n");
        Console.Write(" ответ - {0}\n", StaticClass.GetCount(a));
        Console.WriteLine("\nб) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;\n" +
            "в)**Добавьте обработку ситуации отсутствия файла на диске.\n");
        //Console.Write(" ответ - {0}\n", StaticClass.GetCountInFile(path));
        int[] b = StaticClass.GetCountInFile(path);
        for (int i=0;i<b.Length;i++)
        {
            Console.WriteLine("[{0}]={1}",i,b[i]);
        }
        Console.Write(" ответ - {0}\n", StaticClass.GetCount(b));
        Console.ReadKey();
    }
}

