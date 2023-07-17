namespace dotnet_syntax.Strategy;

public class DecoyDuck : Duck
{
    public DecoyDuck() {
        quackBehavior = new MuteQuack(); // Quack, MuteQuack, Squeak
        flyBehavior = new FlyNoWay(); // FlyNoWay, FlyWithWing
    }
    public override void Display()
    {
        Console.WriteLine("I'm a real Decoy duck");
    }
}