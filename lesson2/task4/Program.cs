using System;

class Program
{
    static Boolean CheckPass(string login, string password)
    {
        string secretLogin = "root";
        string secretPassword = "GeekBrains";
        if (login == secretLogin)
        {
            if (password == secretPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    static void Main(string[] args)
    {
        //Выполнил Дмитрий Ищенко
        //4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, 
        //и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу:
        //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить 
        //ввод пароля тремя попытками.
        Console.WriteLine("4. Реализовать метод проверки логина и пароля.");
        int userTry= 0;
        do
        {
            if (userTry >=3)
            {
                Console.WriteLine("Попытки ввода пароля закончились.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.Write("Введите имя пользователя:");
            string login = Console.ReadLine();
            Console.Write("Введите пароль:");
            string password = Console.ReadLine();
            if (CheckPass(login, password))
            {
                break;
            }
            else
            {
                Console.WriteLine("Комбинация логин/пароль не верные");
            }
            userTry++;
        }
        while (true);
        Console.WriteLine("Добро пожаловать !");
        Console.ReadKey();
    }
}

