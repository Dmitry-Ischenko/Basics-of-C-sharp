using System;
using System.IO;

namespace TDArrayLib
{
    public class TDArray
    {
        //Выполнил Ищенко Дмитрий
        //5.  * а) Реализовать библиотеку с классом для работы с двумерным массивом.
        //          Реализовать конструктор, заполняющий массив случайными числами.
        //          Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, 
        //           свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, 
        //           возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).
        //    **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
        //   ***в) Обработать возможные исключительные ситуации при работе с файлами.
        int[,] array;
        public TDArray(int row,int column)
        {
            array = new int[row, column];
            Random rand = new Random();
            for (int i=0;i<array.GetLength(0);i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(20);
                }
            }
        }
        public TDArray(string path)
        {
            if (!File.Exists(path))
            {
                throw new ArgumentException(String.Format("Файл не найден, работать дальше не буду", path), "path");
            }
            string[] arrayStr = File.ReadAllLines(path);
            int row = 0;
            int column = 0;
            int serchMaxColumn = 0;
            for (int i = 0; i < arrayStr.Length; i++)
            {
                for (int j = 0; j < arrayStr[i].Length; j++)
                {
                    if (arrayStr[i][j] == ' ')
                    {
                        serchMaxColumn++;
                    }
                }
                if (serchMaxColumn > column)
                {
                    column = serchMaxColumn;
                }
                if (serchMaxColumn > 0)
                {
                    row++;
                }
                serchMaxColumn = 0;
            }
            array = new int[row, column + 1];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                string buffer = "";
                int z = 0;
                for (int j = 0; j < arrayStr[i].Length; j++)
                {
                    if (arrayStr[i][j] != ' ')
                    {
                        buffer += arrayStr[i][j];
                    }
                    if (arrayStr[i][j] == ' ' || j == arrayStr[i].Length - 1)
                    {
                        if (Int32.TryParse(buffer, out array[i, z]))
                        {
                            z++;
                        }
                        buffer = "";
                    }
                }
            }

        }
        public int GetSum()
        {
            int summ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    summ+=array[i, j];
                }
            }
            return summ;
        }
        public int GetSum(int num)
        {
            int summ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > num)
                    {
                        summ += array[i, j];
                    }
                }
            }
            return summ;
        }
        public int GetMin
        {
            get
            {
                int min = array[0,0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (min> array[i, j])
                        {
                            min = array[i, j];
                        }
                    }
                }
                return min;
            }
        }
        public int GetMax
        {
            get
            {
                int max = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (max < array[i, j])
                        {
                            max = array[i, j];
                        }
                    }
                }
                return max;
            }
        }
        public void GetMaxIndex(out int row,out int column)
        {
            int max = array[0, 0];
            row = 0;
            column = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        row = i;
                        column = j;
                    }
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ",array[i, j]);
                }
                Console.Write("\n");
            }
        }
        public void PrintToFile(string path)
        {
            if (!File.Exists(path))
            {
                //вернуть исключение
            }
            string[] arrayStr = new string[array.Length];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j==array.GetLongLength(1)-1)
                    {
                        arrayStr[i] += array[i, j].ToString();
                    } 
                    else
                    {
                        arrayStr[i] += array[i, j].ToString() + " ";
                    }
                }
            }
            File.WriteAllLines(path, arrayStr);
        }
    }
}
