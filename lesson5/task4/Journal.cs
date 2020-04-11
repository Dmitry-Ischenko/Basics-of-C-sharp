using System;

class Journal
{
    string firstNamePrivate;
    string lastNamePrivate;
    int[] gradesPrivate;
    public Journal()
    {
        firstNamePrivate = "";
        lastNamePrivate = "";
        gradesPrivate = new int[10];
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
}

