using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    public delegate double Fun(double x);
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
        //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
        //    Использовать массив(или список) делегатов, в котором хранятся различные функции.
        //б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
        //    Пусть она возвращает минимум через параметр(с использованием модификатора out). 
        //Math.Sin(x)
        List<Fun> funcList = new List<Fun>();
        funcList.Add(new Fun(Math.Sin)); // Возвращает синус указанного угла.
        funcList.Add(new Fun(Math.Abs)); //  Возвращает абсолютное значение числа двойной точности с плавающей запятой.
        funcList.Add(new Fun(Math.Cos)); // Возвращает косинус указанного угла.
        funcList.Add(new Fun(Math.Log)); //  Возвращает натуральный логарифм (с основанием e) указанного числа.
        funcList.Add(new Fun(Math.Acos)); //Возвращает угол, синус которого равен указанному числу.
        funcList.Add(new Fun(Func1));
        int index;
        do
        {
            Console.WriteLine("Выберите функцию:\n" +
                "  1. Math.Sin  - Возвращает синус указанного угла.\n" +
                "  2. Math.Abs  - Возвращает абсолютное значение числа двойной точности с плавающей запятой.\n" +
                "  3. Math.Cos  - Возвращает косинус указанного угла.\n" +
                "  4. Math.Log  - Возвращает натуральный логарифм (с основанием e) указанного числа.\n" +
                "  5. Math.Acos - Возвращает угол, синус которого равен указанному числу.\n" +
                "  6. Func1     - ХЗ");
            Console.Write("[1-6]: ");
            if (Int32.TryParse(Console.ReadLine(),out index))
            {
                if (index >=1 && index <=6)
                {
                    index--;
                    break;
                }
            }
            Console.WriteLine("Не верное значение, нажмите любую кнопку что бы продолжить");
            Console.ReadKey();
            Console.Clear();            
        } while (true);
        double a;
        double b;
        do
        {
            Console.WriteLine("Укажите начало (А) и конец (B) поиска функции");
            Console.Write("A: ");
            if (double.TryParse(Console.ReadLine(),out a)) {
                Console.Write("B: ");
                if (double.TryParse(Console.ReadLine(), out b)) {
                    if (a < b)
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("a({0}) больше b({1}) - попробуйте снова",a,b);
                    }
                }
            }
        } while (true);
        SaveFunc(funcList[index],"data.bin", a, b, 0.5);
        double minLoad;
        double[] masiv = Load("data.bin", out minLoad);
        for (int i = 0; i < masiv.Length; i++)
        {
            Console.WriteLine("massiv[{0}]={1}",i,masiv[i]);
        }
        Console.WriteLine("min = {0}",minLoad);
        Console.ReadKey();
    }
    public static double Func1(double x)
    {
        return x * x - 50 * x + 10;
    }

    public static void SaveFunc(Fun F,string fileName, double a, double b, double h)
    {
        FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs);
        double x = a;
        while (x <= b)
        {
            bw.Write(F(x));
            x += h;// x=x+h;
        }
        bw.Close();
        fs.Close();
    }
    public static double[] Load(string fileName,out double min)
    {
        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        BinaryReader bw = new BinaryReader(fs);
        Console.WriteLine(bw.ToString());
        min = double.MaxValue;
        double d;
        List<double> buf = new List<double>();
        for (int i = 0; i < fs.Length / sizeof(double); i++)
        {
            // Считываем значение и переходим к следующему
            d = bw.ReadDouble();
            buf.Add(d);
            if (d < min) min = d;
        }
        bw.Close();
        fs.Close();
        return buf.ToArray();
    }
}