namespace dotnet_syntax.Strategy;

public abstract class Duck
{
    public IFlyBehavior flyBehavior;
    public IQuackBehavior quackBehavior;

    public Duck() { }

    public void setFlyBehavior(IFlyBehavior fb) {
        flyBehavior = fb;
    }
    public void setQuackBehavior(IQuackBehavior qb) {
        quackBehavior = qb;
    }
    public abstract void Display();
    
    public void PerformFly() {
        flyBehavior.Fly();
    }
    public void PerformQuack() {
        quackBehavior.Quack();
    }
    public void Swim() {
        Console.WriteLine("All ducks float, even decoys!");
    }
    // Duck mallard = new MallardDuck();
    // mallard.Display();
    // mallard.setFlyBehavior(new FlyRocketPowered());
    // mallard.PerformQuack();
    // mallard.PerformFly();
    // Console.WriteLine("------------------------");
    // Duck decoy = new DecoyDuck();
    // decoy.Display();
    // decoy.PerformQuack();
    // decoy.PerformFly();
}