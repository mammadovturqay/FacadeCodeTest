using System;

/// <summary>
/// Alt sistemler olacaq
/// </summary>
class Subsystem1
{
    public void Operation1()
    {
        Console.WriteLine("Subsystem1: ready !");
    }
}

class Subsystem2
{
    public void Operation2()
    {
        Console.WriteLine("Subsystem2: ready!");
    }
}

class Subsystem3
{
    public void Operation3()
    {
        Console.WriteLine("Subsystem3: ready!");
    }
}

class Subsystem4
{
    public void Operation4()
    {
        Console.WriteLine("Subsystem4: ready");
    }
}

class Facade
{
    private Subsystem1 subsystem1;
    private Subsystem2 subsystem2;
    private Subsystem3 subsystem3;
    private Subsystem4 subsystem4;

    public Facade()
    {
        subsystem1 = new Subsystem1();
        subsystem2 = new Subsystem2();
        subsystem3 = new Subsystem3();
        subsystem4 = new Subsystem4();
    }

    public void OperationA()
    {
        Console.WriteLine("\nFacade work ");
        subsystem1.Operation1();
        subsystem2.Operation2();
    }

    public void OperationB()
    {
        Console.WriteLine("\nFacade work:");
        subsystem3.Operation3();
        subsystem4.Operation4();
    }
}

// Kullanım
class Program
{
    static void Main(string[] args)
    {
        Facade facade = new Facade();

        facade.OperationA(); 
        facade.OperationB(); 

        Console.ReadLine();
    }
}
