using System;
using System.Text;

class Journal
{
    string firstNamePrivate;
    string lastNamePrivate;
    int[] gradesPrivate;
    float averageScore;
    public Journal(string lastName,string firstName, int[] rating)
    {
        firstNamePrivate = firstName;
        lastNamePrivate = lastName;
        gradesPrivate = rating;
        for (int i = 0; i < gradesPrivate.Length; i++)
        {
            averageScore += gradesPrivate[i];
        }
        averageScore = averageScore / gradesPrivate.Length;
    }
    public string firstName
    {
        get
        {
            return firstNamePrivate;
        }
        set
        {
            firstNamePrivate = value;
        }
    }
    public string lastName
    {
        get
        {
            return lastNamePrivate;
        }
        set
        {
            lastNamePrivate = value;
        }
    }
    public int this[int index]
    {
        get
        {
            return gradesPrivate[index];
        }
        set
        {
            gradesPrivate[index] = value;
        }
    }
    public float AverageScore
    {
        get
        {
            return averageScore;
        }
    }
    public override string ToString()
    {
        StringBuilder newstring = new StringBuilder();
        for (int i = 0; i < gradesPrivate.Length; i++)
        {
            if (i >0)
            {
                newstring.Append(" ");
            }
            newstring.Append(gradesPrivate[i]);
        }
        return String.Format("{0} {1} {2}  средний бал = {3:.00}", 
            lastNamePrivate, firstNamePrivate, newstring, averageScore);
    }
}

