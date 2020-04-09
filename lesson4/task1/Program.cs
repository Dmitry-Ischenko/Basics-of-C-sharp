using System;

class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //1.Дан  целочисленный массив  из 20 элементов.
        //  Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
        //  Заполнить случайными числами.
        //  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
        //  В данной задаче под парой подразумевается два подряд идущих элемента массива. 
        //  Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
        int randMin = -10000;
        int randMax = 10000;
        int arrayLength = 20;
        //-------------------------
        int [] a = new int[arrayLength];
        Random random = new Random();
        for (int i =0;i<a.Length;i++)
        {
            a[i] = random.Next(randMin, randMax);
        }

        Console.Write(" ответ - {0}", GetCount(a));

        Console.ReadKey();
    }
    public static int GetCount(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (i + 1 < array.Length)
            {
                if ((array[i] % 3 == 0) || (array[i + 1] % 3 == 0))
                {
                    count++;
                }
                Console.Write("{0}; {1}", array[i], array[i + 1]);
                if (i < array.Length - 2)
                {
                    Console.Write("; ");
                }
            }
            else
            {
                Console.Write("{0} ", array[i]);
            }
        }
        return count;
    }
}

