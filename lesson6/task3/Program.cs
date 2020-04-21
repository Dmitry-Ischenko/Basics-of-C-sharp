using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //Переделать программу Пример использования коллекций для решения следующих задач:
        //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
        //в) отсортировать список по возрасту студента;
        //г) *отсортировать список по курсу и возрасту студента;
        int bakalavr = 0;
        int magistr = 0;
        int course5Count = 0;
        int course6Count = 0;
        int studentDAge = 0;
        List<Student> list = new List<Student>();                             // Создаем список студентов
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("students_1.csv",Encoding.GetEncoding(1251));
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                // Добавляем в список новый экземпляр класса Student
                list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                // Одновременно подсчитываем количество бакалавров и магистров
                if (list[list.Count - 1].course < 5) bakalavr++; else magistr++;
                if (list[list.Count - 1].course == 5) course5Count++;
                if (list[list.Count - 1].course == 6) course6Count++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                // Выход из Main
                if (Console.ReadKey().Key == ConsoleKey.Escape) return;
            }
        }
        sr.Close();
        list.Sort(new Comparison<Student>(MyDelegat));
        Console.WriteLine("Всего студентов:" + list.Count);
        Console.WriteLine("Магистров:{0}", magistr);
        Console.WriteLine("Бакалавров:{0}", bakalavr);
        Console.WriteLine("Студентов на 5м курсе:{0}", course5Count);
        Console.WriteLine("Студентов на 6м курсе:{0}", course6Count);
        foreach (var v in list)
        {
            if (v.Age >= 16 && v.Age <= 20)
            {
                studentDAge++;
                Console.WriteLine("Студент: {0} {1}, возраст {2}, учится на курсе {3}", v.lastName, v.firstName, v.Age, v.course);
            }
        }
        Console.WriteLine("Количество студентов в возсрасте от 18 до 20: {0}",studentDAge);
        Console.WriteLine("До сортировки по возрасту:");
        Console.WriteLine("----------------------------");
        foreach (var v in list) Console.WriteLine(v.Age);
        list.Sort(delegate (Student x, Student y)
        {
            if (x.Age > y.Age) return 1;
            else if (x.Age == y.Age) return 0;
            return -1;
        });
        Console.WriteLine("----------------------------");
        Console.WriteLine("После сортировки по возрасту");
        Console.WriteLine("----------------------------");
        foreach (var v in list) Console.WriteLine(v.Age);
        Console.WriteLine("----------------------------");
        Console.WriteLine("После сортировки по возрасту и курсу");
        Console.WriteLine("----------------------------");
        list.Sort(delegate (Student x, Student y)
        {
            if (x.course > y.course) return 1;
            else if (x.course == y.course)
            {
                if (x.Age > y.Age) return 1;
                else if (x.Age == y.Age) return 0;
                return -1;
            }
            return -1;
        });
        foreach (var v in list) Console.WriteLine("Курс:{0}, Возраст:{1}",v.course, v.Age);
        Console.WriteLine(DateTime.Now - dt);
        Console.ReadKey();
    }
    static int MyDelegat(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
    {

        return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
    }
}