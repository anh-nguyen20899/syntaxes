namespace dotnet_syntax.Decorator;
public class Whip : CondimentDecorator {
    public Whip(Beverage beverage) {
        this.beverage = beverage;
    }
    public override String getDescription() {
        return beverage.getDescription() + ", Whip";
    }
    public override double cost() {
        return beverage.cost() + .10;
    }
}