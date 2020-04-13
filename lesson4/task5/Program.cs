using System;
using TDArrayLib;
class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //5.  * а) Реализовать библиотеку с классом для работы с двумерным массивом.
        //          Реализовать конструктор, заполняющий массив случайными числами.
        //          Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, 
        //           свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, 
        //           возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).
        //    **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
        //   ***в) Обработать возможные исключительные ситуации при работе с файлами.
        string path = "array.txt";
        int row=10, column=10;
        TDArray myArray = new TDArray(row, column);
        myArray.Print();
        Console.WriteLine("Сумма всех элементов массива равана: {0}", myArray.GetSum());
        Console.WriteLine("Сумма элементов массива больше 10 равана: {0}", myArray.GetSum(10));
        Console.WriteLine("Минимальный элемент массива: {0}", myArray.GetMin);
        Console.WriteLine("Максимальный элемент массива: {0}", myArray.GetMax);
        myArray.GetMaxIndex(out row, out column);
        Console.WriteLine("Индекс максиимального элемента строка - {0}, столбец - {1} (отсчет идет от 0, если забыли)",row,column);
        Console.WriteLine("Сохраним все наше добро в файл {0}",path);
        myArray.PrintToFile(path);
        Console.WriteLine("------------------");
        Console.WriteLine("А теперь созданим новый объект, и считаем в него значения из файла (нажмите любую кнопку, что бы продолжить)");
        Console.ReadKey();
        TDArray myArray2 = new TDArray(path);
        myArray2.Print();
        Console.ReadKey();
    }
}