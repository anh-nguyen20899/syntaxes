namespace dotnet_syntax.Decorator;
public class Mocha : CondimentDecorator {
    public Mocha(Beverage beverage) {
        this.beverage = beverage;
    }
    public override String getDescription() {
        return this.beverage.getDescription() + ", Mocha";
    }
    public override double cost() {
        return beverage.cost() + .20;
    }
}