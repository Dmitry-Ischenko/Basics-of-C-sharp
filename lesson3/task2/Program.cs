using System;
class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //2.а) С клавиатуры вводятся числа, пока не будет введен 0(каждое число в новой строке).
        //     Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
        //  б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
        //     При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
        Console.WriteLine("а) С клавиатуры вводятся числа, пока не будет введен 0(каждое число в новой строке). \n" +
            "   Требуется подсчитать сумму всех нечетных положительных чисел.\n" +
            "   Сами числа и сумму вывести на экран, используя tryParse;\n" +
            "б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.\n" +
            "   При возникновении ошибки вывести сообщение.Напишите соответствующую функцию\n");
        string numberInLine="";
        int number;
        int summ = 0;
        do
        {
            number = GetInt();
            if (number % 2 > 0)
            {
                summ += number;
                numberInLine += number + " ";
            }
        }
        while (number != 0);
        Console.WriteLine($"Вы ввели нечетные числа [ {numberInLine}], сумма этих чисел равна: {summ}");
        Console.ReadKey();
    }
    static int GetInt(string msg = "Введите число: ")
    {
        int number;
        bool isNumber;
        string readLine;
        do
        {
            Console.Write(msg);
            readLine = Console.ReadLine();
            isNumber = Int32.TryParse(readLine, out number);
            //Console.Write("\n");
            if (!isNumber)
            {
                Console.WriteLine("\nВы ввели \"{0}\" - это не число\n", readLine);
            }
        } while (!isNumber);
        return number;
    }
}