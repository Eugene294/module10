using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Worker w = new Worker();
        w.Build();
    }
}

public interface IWorker
{
     void Build();
}

class Worker : IWorker
{

    public void Build()
    {
        Console.WriteLine("Building");
    }

}
