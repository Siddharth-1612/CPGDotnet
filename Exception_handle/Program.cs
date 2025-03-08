using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Accessing the 10th element: " + numbers[10]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: Attempted to access an index that is out of bounds.");
            Console.WriteLine("Exception Message: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
