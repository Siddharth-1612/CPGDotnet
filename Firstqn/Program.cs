using System;
class Student
{
    public virtual void student_details()
    {
        Console.WriteLine("graduate student details details are :");
    }
    public string student_details(string name)
    {
        Console.WriteLine($"The name of the student name is {name}");
        return name;
    }

    public int student_details(int roll_no)
    {
        Console.WriteLine($"The roll no is {roll_no}");
        return roll_no;
    }
}
class Graduate_students:Student
{
    public override void student_details()
    {
        Console.WriteLine("Name:John Age:21");
    }
}

class Program
{
    static void Main()
    {
        Student obj_1=new Student();
        obj_1.student_details("Siddharth");
        Student obj_2= new Student();
        obj_2.student_details(1001);
        Graduate_students obj_3 =new Graduate_students();
        obj_3.student_details();
    
    }
}