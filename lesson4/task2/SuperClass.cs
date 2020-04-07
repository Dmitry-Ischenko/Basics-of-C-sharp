using System;
using System.IO;
class SuperClass
{
    public static int GetCount(int [] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (i+1< array.Length)
            { 
                if ((array[i] % 3 == 0) || (array[i + 1] % 3 == 0))
                {
                    count++;
                }
                Console.Write("{0}; {1}", array[i], array[i + 1]);
                if (i < array.Length - 2)
                {
                    Console.Write("; ");
                }
            }
            else
            {
                Console.Write("{0} ", array[i]);
            }
        }
        return count;
    }
    public static int  GetCountInFile(string path)
    {
        if (!File.Exists(path))
        {
            return 0;
        }
        try
        {
            string[] arrayStr = File.ReadAllLines(path);
            int[] array = new int[arrayStr.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (!Int32.TryParse(arrayStr[i], out array[i]))
                {
                    array[i] = 0;
                }
            }
            return GetCount(array);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }
}

