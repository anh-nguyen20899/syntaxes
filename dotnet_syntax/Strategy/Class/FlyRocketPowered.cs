namespace dotnet_syntax.Strategy;
public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with A ROCKET");
    }
}