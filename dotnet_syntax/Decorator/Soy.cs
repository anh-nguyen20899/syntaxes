namespace dotnet_syntax.Decorator;
public class Soy : CondimentDecorator {
    public Soy(Beverage beverage) {
        this.beverage = beverage;
    }
    public override String getDescription() {
        return beverage.getDescription() + ", Soy";
    }
    public override double cost() {
        return beverage.cost() + .15;
    }
}