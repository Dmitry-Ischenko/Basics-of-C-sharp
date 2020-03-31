using System;

class Program
{
    static void Main(string[] args)
    {
        //Выполнил Дмитрий Ищенко
        //4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, 
        //и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу:
        //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить 
        //ввод пароля тремя попытками.
        Console.WriteLine("4. Реализовать метод проверки логина и пароля.");
        string secretLogin = "root";
        string secretPassword = "GeekBrains";
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
            userTry++;
            if (login == secretLogin)
            {
                if (password == secretPassword)
                {
                    break;
                } else
                {
                    Console.WriteLine("Комбинация логин/пароль не верные");
                }
            }else
            {
                Console.WriteLine("Комбинация логин/пароль не верные");
            }
    }
        while (true);
        Console.WriteLine($"Добро пожаловать {secretLogin}!");
        Console.ReadKey();
    }
}

