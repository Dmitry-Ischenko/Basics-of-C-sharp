using System;
using System.Collections.Generic;
using System.Text;

static class Message
{
    //а) Вывести только те слова сообщения,  которые содержат не более n букв.
    public static void NotMoreWord(string input, int n)
    {
        string[] separators = { ",", ".", "!", "?", ";", ":", " " };
        string[] split = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < split.Length; i++)
        {
            if (split[i].Length <= n)
            {
                Console.WriteLine(split[i]);
            }
        }
    }
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    public static void DeleteWordWithLetters(string input, char letters)
    {
        string[] separators = { ",", ".", "!", "?", ";", ":", " " };
        string[] split = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder outputString = new StringBuilder(input);
        for (int i = 0; i < split.Length; i++)
        {
            if ((split[i][split[i].Length - 1] == letters))
            {
                outputString.Replace(split[i], "");
            }
        }
        Console.WriteLine("Строка после удаления: {0}", outputString);
    }

    //в) Найти самое длинное слово сообщения.
    public static void LongWord(string input)
    {
        string[] separators = { ",", ".", "!", "?", ";", ":", " " };
        string[] split = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int maxLong = split[0].Length;
        int index = 0;
        for (int i = 0; i < split.Length; i++)
        {
            if (split[i].Length > maxLong)
            {
                maxLong = split[i].Length;
                index = i;
            }
        }
        Console.WriteLine(split[index]);
    }
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    public static void MaxLongWord(string input)
    {
        string[] separators = { ",", ".", "!", "?", ";", ":", " " };
        string[] split = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int maxLong = split[0].Length;
        for (int i = 0; i < split.Length; i++)
        {
            if (split[i].Length > maxLong)
            {
                maxLong = split[i].Length;
            }
        }
        StringBuilder mySuperString = new StringBuilder();
        for (int i = 0; i < split.Length; i++)
        {
            if (split[i].Length == maxLong)
            {
                if (mySuperString.Length > 1)
                {
                    mySuperString.Append(" ");
                }
                mySuperString.Append(split[i]);
            }
        }
        Console.WriteLine("Самые длинные слова: {0}", mySuperString);
    }
    //д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, 
    //            в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
    public static void FrequencyAnalysis(string input, string[] words)
    {
        string[] separators = { ",", ".", "!", "?", ";", ":", " " };
        string[] split = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> frequencyWords = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            frequencyWords.Add(words[i], 0);
        }
        for (int i = 0; i < split.Length; i++)
        {
            if (frequencyWords.ContainsKey(split[i]))
            {
                frequencyWords[split[i]]++;
            }
        }
        foreach (var item in frequencyWords)
        {
            Console.WriteLine("{0} - {1}", item.Key, item.Value);
        }

    }
}

