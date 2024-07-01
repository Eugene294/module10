using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        ;
    }
}

public interface IBook
{
    void Read();
}

public interface IDevice
{
    void TurnOn();
    void TurnOff();
}

class ElectronicBook : IBook, IDevice
{
    public void Read() { }
    public void TurnOn() { }
    public void TurnOff() { }
}
