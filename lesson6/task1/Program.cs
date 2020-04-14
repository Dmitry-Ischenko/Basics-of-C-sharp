using System;

class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double(double, double).
        //    Продемонстрировать работу на функции с функцией a*x ^ 2 и функцией a* sin(x).
        //---------------------------------------------------------------------------------
        // Создаем новый делегат и передаем ссылку на него в метод Table
        Console.WriteLine("Таблица функции MyFunc:");
        // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
        //Table(new Fun(MyFunc), -2, 2);
        //Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
        //// Упрощение(c C# 2.0).Делегат создается автоматически.            
        //Table(MyFunc, -2, 2);
        //Console.WriteLine("Таблица функции Sin:");
        //Table(Math.Sin, -2, 2);      // Можно передавать уже созданные методы
        //Console.WriteLine("Таблица функции x^2:");
        //// Упрощение(с C# 2.0). Использование анонимного метода
        //Table(delegate (double x) { return x * x; }, 0, 3);
        //Console.ReadKey();
        Console.WriteLine("Таблица функции MyFunc:");
        // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
        Table(-2, 2, new Fun(MyFunc));
        Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
        // Упрощение(c C# 2.0).Делегат создается автоматически.            
        Table(-2, 2, MyFunc);
        Console.WriteLine("Таблица функции Sin:");
        Table(-2, 2, Math.Sin);      // Можно передавать уже созданные методы
        Console.WriteLine("Таблица функции x^2:");
        // Упрощение(с C# 2.0). Использование анонимного метода
        Table(0, 3, delegate (double x) { return x * x; });
        Console.WriteLine("А теперь с функцией double(double, double)");
        Console.WriteLine("a*x ^ 2");
        Table(-2, 2,null,new Fun2(MyFunc2),2);
        Console.WriteLine("a* sin(x)");
        Table(-2, 2,null,new Fun2(MyFunc3),2);
        Console.ReadKey();
    }
    // Создаем метод для передачи его в качестве параметра в Table
    public static double MyFunc(double x)
    {
        return x * x * x;
    }
    public static double MyFunc2(double x, double a)
    {
        return a * x * x;
    }
    public static double MyFunc3(double x, double a)
    {
        return a * Math.Sin(x);
    }
    // Создаем метод, который принимает делегат
    // На практике этот метод сможет принимать любой метод
    // с такой же сигнатурой, как у делегата
    public static void Table(double x, double b, Fun F = null, Fun2 F2 = null, double a=0)
    {
        if (F != null)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        if (F2 != null) {

            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F2(x,a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
    }
    public delegate double Fun(double x);
    public delegate double Fun2(double x, double a);
}
