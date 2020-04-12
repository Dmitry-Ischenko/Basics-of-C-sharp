using System;

class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //*Задача ЕГЭ.
        //На вход программе подаются сведения о сдаче экзаменов учениками 9 - х классов некоторой средней школы. 
        //    В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
        //    < Фамилия > < Имя > < оценки >, где 
        //    < Фамилия > — строка, состоящая не более чем из 20 символов, < Имя > — строка, состоящая не более чем из 15 символов,
        //    < оценки > — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. 
        //    < Фамилия > и<Имя>, а также<Имя> и<оценки> разделены одним пробелом. Пример входной строки:
        //    Иванов Петр 4 5 3
        //    Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
        //    Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
        int count;
        Journal[] list;
        do
        {
            Console.Write("Введите количество учеников от 10 но не более 100:");
            Int32.TryParse(Console.ReadLine(), out count);
            if (count == 0) break;
        } while (count < 10 || count > 100);
        if (count == 0) {
            Console.WriteLine("\nЛадно, сам заполню");
            list = new Journal[10];
            string[] lastname =
            {
                "Иванов",
                "Васильев",
                "Петров",
                "Смирнов",
                "Михайлов",
                "Фёдоров",
                "Соколов",
                "Яковлев",
                "Попов",
                "Андреев"
            };
            string[] firstname =
            {
                "Абрам",
                "Аваз",
                "Август",
                "Авдей",
                "Автандил",
                "Адам",
                "Адис",
                "Адольф",
                "Адриан",
                "Азарий"
            };
            Console.WriteLine("Допустим:");
            Random rand = new Random();
            for (int i = 0; i < list.Length; i++)
            {
                int[] b = new int[3];
                b[0] = rand.Next(2, 6);
                b[1] = rand.Next(2, 6);
                b[2] = rand.Next(2, 6);
                list[i] = new Journal(lastname[i], firstname[i], b);
                Console.WriteLine(list[i].ToString());
            } 
        }
        else { 
            list = new Journal[count];
            Msg();
            for (int i = 0; i < list.Length; i++)
            {
                Boolean check = false;
                do
                {
                    Console.Write("[{0}]:", i);
                    string[] split = Console.ReadLine().Split(' ');
                    if (split.Length ==5)
                    {
                        if (split[0].Length<=20)
                        {
                            if (split[1].Length <=15)
                            {
                                int[] rating = new int[3];
                                for (int j = 0; j < rating.Length; j++)
                                {
                                    if (Int32.TryParse(split[2+j],out rating[j])) {
                                        if (rating[j]>0 && rating[j]<=5)
                                        {
                                            check = true;
                                        }
                                        else
                                        {
                                            check = false;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        check = false;
                                        break;
                                    }
                                }
                                if (check)
                                {
                                    list[i] = new Journal(split[0], split[1], rating);
                                    break;
                                }

                            }
                        }
                    }
                    Console.WriteLine("Не верный формат");
                    Msg();
                    check = true;
                } while (check);
            }
        }
        for (int i = 0; i < list.Length; i++)
        {
            for (int j = i; j < list.Length; j++)
            {
                if (list[j].AverageScore < list[i].AverageScore)
                {
                    (list[i], list[j]) = (list[j], list[i]);
                }
            }
        }
        Console.WriteLine("\nСамые худшие по среднему балу ученики:");
        int badman = 0;
        for (int i = 0; i < list.Length; i++)
        {
            if (i>0)
            {
                if (badman < 3)
                {
                    Console.WriteLine(list[i].ToString());
                    badman++;
                } else if (list[i].AverageScore == list[i-1].AverageScore)
                {
                    Console.WriteLine(list[i].ToString());
                } else
                {
                    break;
                }
            } else
            {
                Console.WriteLine(list[i].ToString());
                badman++;
            }
        }
        Console.ReadKey();
    }
    static void Msg()
    {
        Console.WriteLine("Введите данные учеников в формате: \n < Фамилия > < Имя > < оценки >" +
                            "< Фамилия > — строка, состоящая не более чем из 20 символов, < Имя > — строка, состоящая не более чем из 15 символов\n" +
                            "< оценки > — через пробел три целых числа, соответствующие оценкам по пятибалльной системе\n" +
                            "< оценки > — через пробел три целых числа, соответствующие оценкам по пятибалльной системе\n");
    }
}

