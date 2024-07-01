using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Worker w = new Worker();
        ((IWorker)w).Build();
    }
}

public interface IWorker
{
    void Build();
}

class Worker : IWorker
{

    void IWorker.Build()
    {
        Console.WriteLine("Building");
    }

}
