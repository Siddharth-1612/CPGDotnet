using System;

class Parent
{
    public void Show()
    {
        Console.WriteLine("Parent's method");
    }
}

class Child : Parent
{
    public new void Show() 
    {
        Console.WriteLine("Child's  method");
    }
}

class Program
{
    static void Main()
    {
        Parent obj1 = new Parent();
        obj1.Show(); 

        Child obj2 = new Child();
        obj2.Show(); 

        Parent obj3 = new Child();
        obj3.Show(); 
    }
}
