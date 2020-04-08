using System;

namespace TDArray
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
                for(int j = 0; j < array.GetLength(1); i++)
                {
                    array[i, j] = rand.Next(20);
                }
            }
        }
        public int GetSum()
        {
            int summ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); i++)
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
                for (int j = 0; j < array.GetLength(1); i++)
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
                    for (int j = 0; j < array.GetLength(1); i++)
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
                    for (int j = 0; j < array.GetLength(1); i++)
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
          
    }
}
