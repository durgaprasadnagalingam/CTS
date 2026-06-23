using System;
using System.Collections.Generic;

interface IObserver
{
    void Update(string message);
}

class Observer : IObserver
{
    private string name;

    public Observer(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine(name + " received: " + message);
    }
}

class Subject
{
    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
}

class Program
{
    static void Main()
    {
        Subject subject = new Subject();

        Observer obs1 = new Observer("Student1");
        Observer obs2 = new Observer("Student2");

        subject.Attach(obs1);
        subject.Attach(obs2);

        subject.Notify("New assignment uploaded");
    }
}