using System;
using System.IO;
namespace ArrayLib
{
    public class CoolArrayDll
    {
        private int[] a;
        Random rnd = new Random();

        public CoolArrayDll(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(1, 101);
        }
        public CoolArrayDll(int lenght, int start, int step)
        {
            a = new int[lenght];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = start;
                start += step;
            }
        }

        public CoolArrayDll(string filename)
        {
            //Если файл существует
            if (File.Exists(filename))
            {
                //Считываем все строки в файл 
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                //Переводим данные из строкового формата в числовой
                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else Console.WriteLine("Error load file");
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }
        public CoolArrayDll Inverse
        {
            get
            {
                CoolArrayDll arrayInverse = new CoolArrayDll(this.a.Length);
                for (int i = 0; i < a.Length; i++)
                {
                    arrayInverse[i] = a[i] * -1;
                }
                return arrayInverse;
            }
        }
        public void Multi(int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= x;
            }
        }
        public int MaxCount()
        {
            if (a.Length > 1)
            {
                int max = a[0];
                int maxCount = 0;
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > max) max = a[i];
                }
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == max) maxCount++;
                }
                return maxCount;
            }
            else
            {
                return 0;
            }
        }
        //public int Max
        //{
        //    get
        //    {
        //        return a.Max();
        //    }
        //}
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }
        public void Print()
        {
            foreach (int el in a)
                Console.Write("{0,4}", el);
            Console.Write("\n");
        }
    }
}