using System;

class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        //    Например:
        //    badc являются перестановкой abcd.
        string str1 = "", str2 = "";
        Console.Write("Введите строку1:");
        str1 = Console.ReadLine();
        Console.Write("Введите \"{0}\" задом на перед:",str1);
        str2 = Console.ReadLine();
        Console.WriteLine("является ли строка \"{1}\", перестановкой строки \"{0}\" - {2} ",str1,str2, wtf(str1, str2) ? "Да" : "Нет");
        Console.ReadKey();
    }
    static Boolean wtf(string str1, string str2)
    {
        if (str1.Length == str2.Length)
        {
            for (int i=0;i<str2.Length;i++)
            {
                if (!(str1[i] == str2[str2.Length-1-i]))
                {
                    return false;
                }
            }
            return true;
        }
        return false;
    }
}

