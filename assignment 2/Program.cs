using System;

class Student
{
    // Field
    private int age;

    // Property
    public string Name { get; set; }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method
    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main()
    {
        // Creating an object
        Student student1 = new Student("Mohana", 25);

        // Calling method
        student1.Display();
    }
}