using System;

public sealed class Singleton
{
    private static Singleton instance;

    private Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("Singleton Pattern Implemented Successfully");
    }
}

class Program
{
    static void Main()
    {
        Singleton obj = Singleton.GetInstance();
        obj.ShowMessage();
    }
}