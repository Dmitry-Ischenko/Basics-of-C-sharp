using System;
class Program
{
    static int GetInt(string msg = "Введите число")
    {
        int number;
        bool isNumber;
        do
        {
            Console.WriteLine(msg);
            isNumber = Int32.TryParse(Console.ReadLine(), out number);
        } while (!isNumber);
        return number;
    }
    static void Main(string[] args)
    {
        //Выполнил Дмитрий Ищенко
        //5.а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
        //    нужно ли человеку похудеть, набрать вес или все в норме;
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        Console.WriteLine("Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, " +
            "нужно ли человеку похудеть, набрать вес или все в норме.");
        float ur_height = (float)GetInt("Введите ваш рост(см):")/100;
        float ur_weight = GetInt("Введите ваш вес (кг):");
        float indexIMT = ur_weight / (ur_height * ur_height);
        //Индекс массы тела Соответствие между массой человека и его ростом
        //16 и менее  Выраженный дефицит массы тела
        //16—18,5 Недостаточная(дефицит) масса тела
        //18,5—24,99  Норма сдренее число 22
        //25—30   Избыточная масса тела(предожирение)
        //30—35   Ожирение
        //35—40   Ожирение резкое
        //40 и более  Очень резкое ожирение
        Console.Write($"Ваш индекс массы тела равен (ИМТ) {indexIMT}");
        if (indexIMT <= 16)
        {
            Console.WriteLine(" - это выраженный дефицит массы тела. Рекомендуется набрать вес на " + Math.Abs(ur_weight-(22*ur_height * ur_height)) + "кг");
        }
        else if (indexIMT <= 18.5)
        {
            Console.WriteLine(" - это Недостаточная(дефицит) масса тела. Рекомендуется набрать вес на " + Math.Abs(ur_weight - (22 * ur_height * ur_height)) + "кг");
        }
        else if (indexIMT <= 24.99)
        {
            Console.WriteLine(" - это Норма.");
        }
        else if (indexIMT <= 30)
        {
            Console.WriteLine(" - это Избыточная масса тела. Рекомендуется сбросить вес на " + Math.Abs(ur_weight - (22 * ur_height * ur_height)) + "кг");
        }
        else if (indexIMT <= 35)
        {
            Console.WriteLine(" - это Ожирение. Рекомендуется сбросить вес на " + Math.Abs(ur_weight - (22 * ur_height * ur_height)) + "кг");
        }
        else if (indexIMT <= 40)
        {
            Console.WriteLine(" - это Ожирение резкое. Рекомендуется сбросить вес на " + Math.Abs(ur_weight - (22 * ur_height * ur_height)) + "кг");
        }
        else
        {
            Console.WriteLine(" - это Очень резкое ожирение. Рекомендуется сбросить вес на " + Math.Abs(ur_weight - (22 * ur_height * ur_height)) + "кг");
        }
        Console.ReadKey();
    }
}
