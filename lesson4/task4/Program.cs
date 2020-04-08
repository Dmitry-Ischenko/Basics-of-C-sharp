using System;
using System.IO;

   class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //4.Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
        //Создайте структуру Account, содержащую Login и Password.
        string path = "password.txt";
        int userTry = 0;
        Account security = new Account(path);
        do
        {
            if (userTry >= 3)
            {
                Console.WriteLine("\nПопытки ввода пароля закончились.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.Write("Введите имя пользователя:");
            string login = Console.ReadLine();
            Console.Write("Введите пароль:");
            string password = Console.ReadLine();
            if (security.CheckPass(login, password))
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
struct Account
{
    string login;
    string password;

    public Account(string path)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("Файл с паролем отсутсвует, приложение будет завершено");
            Console.ReadKey();
            Environment.Exit(0);
        }
        string[] arrayStr = File.ReadAllLines(path);
        if (arrayStr.Length<2)
        {
            Console.WriteLine("Не верный формат файла с паролем, приложение будет завершено\nВ файле, в первой строке необходимо указать логин, во второй строке пароль");
            Console.ReadKey();
            Environment.Exit(0);
        }
        login = arrayStr[0];
        password= arrayStr[1];
    }
    public Boolean CheckPass(string usrLogin,string usrPassword)
    {
        if (login == usrLogin)
        {
            if (password == usrPassword)
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
}

