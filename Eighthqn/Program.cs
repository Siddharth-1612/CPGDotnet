using System;

abstract class Payment
{
    public abstract void ProcessPayment();
}

class CreditCardPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing Credit Card Payment");
    }
}

class PayPalPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing PayPal Payment");
    }
}

class UpiPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing UPI Payment");
    }
}

class Program
{
    static void Main()
    {
        Payment payment1 = new CreditCardPayment();
        payment1.ProcessPayment();

        Payment payment2 = new PayPalPayment();
        payment2.ProcessPayment();

        Payment payment3 = new UpiPayment(); 
        payment3.ProcessPayment();
    }
}
