using System;

class Program
{
    static void Main(string[] args)
    {
        //Выполнил Ищенко Дмитрий
        //2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
        //а) Вывести только те слова сообщения,  которые содержат не более n букв.
        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        //в) Найти самое длинное слово сообщения.
        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        //д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, 
        //            в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
        //            Здесь требуется использовать класс Dictionary.

        Console.WriteLine("Введите строку");
        string readLine = Console.ReadLine();
        if (readLine.Length < 1)
        {
            readLine = "Иван родил девченеку, велел тащить пеленку";
            Console.WriteLine("Как хотите, у меня есть заготовленная строка\n{0}",readLine);
        }
        Console.WriteLine("\nа) Вывести только те слова сообщения,  которые содержат не более n букв:\n");
        Console.Write("Введите n:");
        int n;
        if (!Int32.TryParse(Console.ReadLine(), out n)) {
            Random rand = new Random();
            n = rand.Next(1,10);
            Console.WriteLine("Ну ладно, допустим будет {0}", n);
        }
        Message.NotMoreWord(readLine, n);
        Console.WriteLine("\nб) Удалить из сообщения все слова, которые заканчиваются на заданный символ.\n");
        Console.Write("Введите символ: ");
        char letter = Char.Parse(Console.ReadLine());
        Message.DeleteWordWithLetters(readLine, letter);
        Console.WriteLine("\nв) Найти самое длинное слово сообщения.\n");
        Message.LongWord(readLine);
        Console.WriteLine("\nг) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.\n");
        Message.MaxLongWord(readLine);
        Console.WriteLine("\nд) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст," +
            "в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.\n");
        Console.WriteLine("Напомню, введенная строка была:\n{0}\n",readLine);
        Boolean isNum;
        int count;
        do
        {
            Console.Write("Введите количество ключевых слов: ");
            isNum = Int32.TryParse(Console.ReadLine(), out count);
        } while (!isNum);
        string[] words = new String[count];
        for (int i=0;i<words.Length;i++)
        {
            Console.Write("Введите слово {0} из {1}:",i+1,words.Length);
            words[i] = Console.ReadLine();
        }
        Console.WriteLine("А теперь посмотрим сколько вхождений у нас нашлось:");
        Message.FrequencyAnalysis(readLine,words);
        Console.ReadKey();
    }
}

