namespace dotnet_syntax.Strategy;

public class MallardDuck : Duck
{
    public MallardDuck() {
        quackBehavior = new Quack(); // Quack, MuteQuack, Squeak
        flyBehavior = new FlyWithWings(); // FlyNoWay, FlyWithWing
    }
    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}