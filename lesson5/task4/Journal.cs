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
    }
    //public int[] grades
    //{
    //    get
    //    {
    //        return gradesPrivate;
    //    }
    //    set
    //    {
    //        gradesPrivate = value;
    //    }
    //}
    //public int grades[int index] {

    //public int grades[int index]
    //{
    //    get
    //    {
    //        return gradesPrivate[index];
    //    }
    //}
}

