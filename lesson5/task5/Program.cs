using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //Этой задачи не было в методичке, но увидел ее на сайте, решил сделать.
        //5. * *Написать игру «Верю.Не верю». В файле хранятся вопрос и ответ, правда это или нет.
        //    Например: «Шариковую ручку изобрели в древнем Египте», «Да». 
        //   Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку.
        //    Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ.
        //    Список вопросов ищите во вложении или воспользуйтесь интернетом.*
        
        Question a = new Question();
        int exit;
        string userAnswer;
        int usrAnsCoun = 0;
        Console.WriteLine("Игра Верю.Не верю");
        do
        {
          
            Console.WriteLine(a.GetQuestion);
            Console.Write("Ваш ответ (Да/Нет, 1- другой вопрос, 2 - завершить программу):");
            userAnswer = Console.ReadLine();
            if (!Int32.TryParse(userAnswer, out exit))
            {
                if (userAnswer.ToLower().Equals(a.GetAnswer.ToLower()))
                {
                    usrAnsCoun++;
                    Console.WriteLine("\nИ это правильный ответ!Вы ответили правильно на {0} вопросов(а)!\n",usrAnsCoun);
                }
                else
                {
                    Console.WriteLine("Не, это неверно. Вы ответили правильно на {0} вопроса(ов)", usrAnsCoun);
                }
            }
        } while (exit !=2);
        Console.WriteLine("Игра кончена. Вы ответили правильно на {0} вопроса(ов)", usrAnsCoun);
        Console.ReadKey();
    }
}

class Question
{
    string[,] question;
    int[] index;
    int questionLengh;
    int getQuestion;
    int iniinitialization = 0;
    public Question()
    {
        string path = "question.txt";
        if (!File.Exists(path))
        {
            throw new ArgumentException(String.Format("Файл не найден, работать дальше не буду", path), "path");
        }
        string[] arrayString = File.ReadAllLines(path);
        Console.WriteLine("Загружено {0} вопросов",arrayString.Length);
        question = new string[7, 2];
        for (int i=0;i<arrayString.Length;i++)
        {
            string[] split = arrayString[i].Split(';');
            if (split.Length>=2) { 
                question[i,0] = split[0];
                question[i, 1] = split[1].Trim();
            } else
            {
                throw new ArgumentException(String.Format("Все пропало командир! Кто-то копашился в файле с вопросами, теперь у него не верный формат!", path), "path");
            }
        }
        questionLengh = question.GetLength(0);
        index = new int[questionLengh];
        for (int i=0;i<index.Length;i++)
        {
            index[i] = i;
        }
    }
    public string GetQuestion
    {
        get
        {
            iniinitialization = 1;
            Random rand = new Random();
            getQuestion = rand.Next(0, questionLengh);
            return question[index[getQuestion], 0];
        }
    }
    public string GetAnswer
    {
        get
        {
            if (iniinitialization == 1) { 
                string answer = question[index[getQuestion], 1];
                index[getQuestion] = index[questionLengh-1];
                index[questionLengh-1] = 0;
                questionLengh--;
                return answer;
            } else
            { 
                return "Для начала задайте вопрос, чтоле";
            }
        }
    }
}
