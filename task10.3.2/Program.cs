using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

    }
}

public interface ICreatable
{
    void Create();
}

public interface IDeletable
{
    void Delete();
}

public interface IUpdatable
{
    void Update();
}

class Entity : ICreatable, IDeletable, IUpdatable
{
    public void Create() { }
    public void Delete() { }
    public void Update() { }
}
