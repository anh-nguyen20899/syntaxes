namespace dotnet_syntax.Decorator;
public abstract class CondimentDecorator : Beverage {
        public Beverage beverage;
        public abstract String getDescription();
}