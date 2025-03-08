using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList numbers = new ArrayList();
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the numbers:");
        for (int i = 0; i < n; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("The ArrayList is empty.");
            return;
        }

        int min = (int)numbers[0];

        foreach (int num in numbers)
        {
            if (num < min)
            {
                min = num;
            }
        }

        Console.WriteLine("Smallest element: " + min);
    }
}
