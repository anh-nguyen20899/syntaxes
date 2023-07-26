namespace dotnet_syntax.Decorator;
public class SteamedMilk : CondimentDecorator {
    public SteamedMilk(Beverage beverage) {
        this.beverage = beverage;
    }
    public override String getDescription() {
        return beverage.getDescription() + ", SteamedMilk";
    }
    public override double cost() {
        return beverage.cost() + .10;
    }
}