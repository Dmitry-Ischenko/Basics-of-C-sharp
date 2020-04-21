using System;

class Student
{
    public string lastName;
    public string firstName;
    public string university;
    public string faculty;
    public int course;
    public string department;
    public int group;
    public string city;
    int age;
    // Создаем конструктор
    public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.university = university;
        this.faculty = faculty;
        this.department = department;
        this.course = course;
        this.age = age;
        this.group = group;
        this.city = city;
    }
    public override string ToString()
    {
        return $"{firstName} {lastName}; Университет: {university}; Факультет: {faculty}; Департамент: {department};Курс: {course}; Возраст: {Age}; Группа: {group}; Город: {city}";
    }
    public int Age
    {
        get
        {
            return age;
        }
    }
}