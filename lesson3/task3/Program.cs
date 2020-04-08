using System;
class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //3. * Описать класс дробей -рациональных чисел, являющихся отношением двух целых чисел.
        //    Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
        //    Написать программу, демонстрирующую все разработанные элементы класса. 
        //    **Добавить проверку, чтобы знаменатель не равнялся 0.
        //    Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
        //    Добавить упрощение дробей.

        Console.WriteLine("3. * Описать класс дробей -рациональных чисел, являющихся отношением двух целых чисел.\n" +
            "      Предусмотреть методы сложения, вычитания, умножения и деления дробей.\n" +
            "      Написать программу, демонстрирующую все разработанные элементы класса.\n" +
            "   **Добавить проверку, чтобы знаменатель не равнялся 0.\n" +
            "      Выбрасывать исключение ArgumentException(\"Знаменатель не может быть равен 0\");\n" +
            "      Добавить упрощение дробей.\n");
        Fraction summFraction1 = new Fraction(2, 5);
        Fraction summFraction2 = new Fraction(3, 10);
        Console.WriteLine("Первая дробь равна: "+ summFraction1.ToString());
        Console.WriteLine("Вторая дробь равна: " + summFraction2.ToString());
        Console.WriteLine("Сумма этих дробей равна: " + summFraction1.Sum(summFraction2));
        Console.WriteLine("Разница этих дробей равна: " + summFraction1.Sub(summFraction2));
        Console.WriteLine("Умножение дробей равна: " + summFraction1.Mult(summFraction2));
        Console.WriteLine("Деление дробей равна: " + summFraction1.Div(summFraction2));
        Console.WriteLine("\nА теперь проверим ArgumentException");
        Console.WriteLine("Нажмите любую клавишу, что бы продолжить");
        Console.ReadKey();
        Fraction summFraction3 = new Fraction(GetInt("Введите числитель: "), GetInt("Введите знаменатель (Если введете \"0\", получим ошибку. Давайте, введите \"0\"): "));
        Console.WriteLine("Вы ввели: " + summFraction3.ToString());
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

