namespace dotnet_syntax.Strategy;
public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Silent - NO Quack");
    }
}