namespace dotnet_syntax.Strategy;

public class RedheadDuck : Duck
{
    public RedheadDuck() {
        quackBehavior = new Squeak(); // Quack, MuteQuack, Squeak
        flyBehavior = new FlyWithWings(); // FlyNoWay, FlyWithWing
    }
    public override void Display()
    {
        Console.WriteLine("I'm a real Redhead duck");
    }
}