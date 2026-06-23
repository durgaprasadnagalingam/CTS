using System;

interface IStrategy
{
    int Execute(int a, int b);
}

class AddStrategy : IStrategy
{
    public int Execute(int a, int b)
    {
        return a + b;
    }
}

class MultiplyStrategy : IStrategy
{
    public int Execute(int a, int b)
    {
        return a * b;
    }
}

class Context
{
    private IStrategy strategy;

    public Context(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public int ExecuteStrategy(int a, int b)
    {
        return strategy.Execute(a, b);
    }
}

class Program
{
    static void Main()
    {
        Context add = new Context(new AddStrategy());
        Console.WriteLine("Addition: " + add.ExecuteStrategy(10, 5));

        Context multiply = new Context(new MultiplyStrategy());
        Console.WriteLine("Multiplication: " + multiply.ExecuteStrategy(10, 5));
    }
}