using System;

interface IPayment
{
    void ProcessPayment();
    void GenerateReceipt();
}

class CreditCardPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing Credit Card Payment...");
    }

    public void GenerateReceipt()
    {
        Console.WriteLine("Credit Card Payment Receipt Generated");
    }
}

class UPIPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing UPI Payment...");
    }

    public void GenerateReceipt()
    {
        Console.WriteLine("UPI Payment Receipt Generated");
    }
} 

class NetBankingPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing Net Banking Payment...");
    }

    public void GenerateReceipt()
    {
        Console.WriteLine("Net Banking Payment Receipt Generated");
    }
}

class Program
{
    static void Main()
    {
        IPayment payment1 = new CreditCardPayment();
        IPayment payment2 = new UPIPayment();
        IPayment payment3 = new NetBankingPayment();

        IPayment[] payments = { payment1, payment2, payment3 };

        foreach (IPayment payment in payments)
        {
            payment.ProcessPayment();
            payment.GenerateReceipt();
            Console.WriteLine();
        }
    }
}