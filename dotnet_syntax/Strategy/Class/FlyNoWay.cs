namespace dotnet_syntax.Strategy;
public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Fly NO WAY");
    }
}