using System;
using ArrayLib;
class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //3. а) Дописать класс для работы с одномерным массивом.
        //      Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        //      Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками 
        //        у всех элементов массива(старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, 
        //        свойство MaxCount, возвращающее количество максимальных элементов. 
        //   б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
        //   е)***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)
        //а)
        int arrowLenght =10;
        int startInt=6;
        int stepInt=3;
        CoolArray myArray = new CoolArray(arrowLenght, startInt, stepInt);
        Console.WriteLine("У нас получился такой массив: ");
        myArray.Print();
        Console.WriteLine("Сумма элементов массива равна: {0}", myArray.Sum);
        CoolArray myArrayInverse = myArray.Inverse;
        Console.WriteLine("Мы создали новый объект");
        myArrayInverse.Print();
        myArray.Multi(7);
        Console.WriteLine("а теперь перемножили");
        myArray.Print();
        Console.WriteLine("Выясним количество максимальных элементов: {0}", myArray.MaxCount());
        Console.ReadKey();
        //б)
        Console.WriteLine("\n\nА теперь все то же самое, но уже с библеотекой DLL");
        arrowLenght = 15;
        startInt = 4;
        stepInt = 5;
        CoolArrayDll myArrayDll = new CoolArrayDll(arrowLenght, startInt, stepInt);
        Console.WriteLine("У нас получился такой массив: ");
        myArrayDll.Print();
        Console.WriteLine("Сумма элементов массива равна: {0}", myArrayDll.Sum);
        CoolArrayDll myArrayInverseDll = myArrayDll.Inverse;
        Console.WriteLine("Мы создали новый объект");
        myArrayInverseDll.Print();
        myArrayDll.Multi(7);
        Console.WriteLine("а теперь перемножили");
        myArrayDll.Print();
        Console.WriteLine("Выясним количество максимальных элементов: {0}", myArrayDll.MaxCount());
        Console.ReadKey();
        // З.ы. Как делать Е я не понял, нужно самим коллекции изучить? у нас коллекции, только на 6м уроке, вроде как, должны быть! 
        //Вот честно, очень низкий уровень подготовки материала
    }
}
