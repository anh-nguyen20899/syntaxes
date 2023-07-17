namespace dotnet_syntax.Strategy;

public interface IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack-----");
    }      
}