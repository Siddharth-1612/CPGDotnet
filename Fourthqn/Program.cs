using System;
class Student
{
    public virtual void student_details()
    {
        Console.WriteLine("graduate student details details are :");
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
        
        Graduate_students obj_3 =new Graduate_students();
        obj_3.student_details();
    
    }
}