using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Writer w = new Writer();
        ((IWriter)w).Write();
    }
}

public interface IWriter
{
    void Write();
}

class Writer : IWriter
{

    void IWriter.Write()
    {
        Console.WriteLine("Writing");
    }

}
