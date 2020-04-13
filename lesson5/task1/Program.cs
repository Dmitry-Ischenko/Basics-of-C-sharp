using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //1. Создать программу, которая будет проверять корректность ввода логина.
        //    Корректным логином будет строка от 2 до 10 символов, содержащая только буквы 
        //    латинского алфавита или цифры, при этом цифра не может быть первой:
        //а) без использования регулярных выражений;
        //б) **с использованием регулярных выражений.
        Console.WriteLine("Введите логин от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой");
        string usrLogin;
        do
        {
            Console.Write("Введите логин:");
            usrLogin = Console.ReadLine();
        } while (!ChekLogin(usrLogin));
        Console.WriteLine("\nА теперь с использованием регулярных выражений");
        string reg = @"^[a-zA-Z]([0-9]|[a-zA-Z]){1,9}$";
        Regex regex = new Regex(reg);
        do
        {
            Console.Write("Введите логин:");
            usrLogin = Console.ReadLine();
        } while (!regex.IsMatch(usrLogin));
        Console.ReadKey();

    }
    static Boolean ChekLogin(string usrLogin)
    {
        if (usrLogin.Length >= 2 && usrLogin.Length <=10)
        {
            if (!Char.IsNumber(usrLogin[0])) {
                for (int i=0;i<usrLogin.Length;i++)
                {
                    if (!(usrLogin[i] >= 'A' && usrLogin[i] <= 'Z' || usrLogin[i] >= '0' && usrLogin[i] <= '9' || usrLogin[i] >= 'a' && usrLogin[i] <= 'z'))
                    //if (!Char.IsLetterOrDigit(usrLogin[i]))
                    {
                        return false;
                    }
                }
                return true;
            } 
        }
        return false;
    }
}
