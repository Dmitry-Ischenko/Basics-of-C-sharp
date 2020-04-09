using System;
using System.IO;
static class StaticClass
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
    public static int[] GetCountInFile(string path)
    {
        int[] array;
        if (!File.Exists(path))
        {
            return StaticClass.FillArray(out array);
        }
        try
        {
            string[] arrayStr = File.ReadAllLines(path);
            int row = 0;
            for (int i = 0; i < arrayStr.Length; i++)
            {
                if (arrayStr[i].Length>0)
                {
                    row++;
                }
            }
            array = new int[row];
            int z = 0;
            for (int i = 0; i < arrayStr.Length; i++)
            {
                if (Int32.TryParse(arrayStr[i], out array[z]))
                {
                    z++;
                }
            }
            return array;
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
            return StaticClass.FillArray(out array);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return StaticClass.FillArray(out array);
        }
    }
    public static int[] FillArray(out int[] array,int randMin= -10000, int randMax= 10000, int row=20)
    {
        Random random = new Random();
        array = new int[row];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(randMin, randMax);
        }
        return array;
    }
}

