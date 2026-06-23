using System;

interface IMessage
{
    void Display();
}

class SimpleMessage : IMessage
{
    public void Display()
    {
        Console.WriteLine("Hello");
    }
}

class MessageDecorator : IMessage
{
    protected IMessage message;

    public MessageDecorator(IMessage message)
    {
        this.message = message;
    }

    public virtual void Display()
    {
        message.Display();
    }
}

class FancyMessage : MessageDecorator
{
    public FancyMessage(IMessage message) : base(message)
    {
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Welcome to Decorator Pattern");
    }
}

class Program
{
    static void Main()
    {
        IMessage msg = new FancyMessage(new SimpleMessage());
        msg.Display();
    }
}