namespace dotnet_syntax.Strategy;

public class RubberDuck : Duck
{
    public RubberDuck() {
        quackBehavior = new Squeak(); // Quack, MuteQuack, Squeak
        flyBehavior = new FlyNoWay(); // FlyNoWay, FlyWithWing
    }
    public override void Display()
    {
        Console.WriteLine("I'm a real Rubber duck");
    }
}