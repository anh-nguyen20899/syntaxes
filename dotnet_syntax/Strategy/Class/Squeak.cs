namespace dotnet_syntax.Strategy;
public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Sounds Squeak Squeak Squeak");
    }
}