using System;

class Student
{

    private string name;
    private int id;

    public Student(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student ID: " + id);
    }

    public void UpdateName(string newName)
    {
        name = newName;
    }

    public void UpdateId(int newId)
    {
        id = newId;
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("Rahul", 107);
        Student student2 = new Student("Raja", 105);

        Console.WriteLine("Original Student Details:");
        student1.DisplayInfo();
        student2.DisplayInfo();

        student1.UpdateName("Rahul Rozario");
        student1.UpdateId(207);

        student2.UpdateName("Raja Rajeshwaran");
        student2.UpdateId(205);

        Console.WriteLine("Updated Student Details:");
        student1.DisplayInfo();
        student2.DisplayInfo();
    }
}