using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

    }
}

public interface IWriter
{
    void Write();
}

public interface IReader
{
    void Read();
}

public interface IMailer
{
    void SendEmail();
}

class FileManager : IWriter, IReader, IMailer
{

    public void Write() { Console.WriteLine("Writing"); }
    public void Read() { Console.WriteLine("Reading"); }
    public void SendEmail() { Console.WriteLine("Sending"); }
}
