namespace dotnet_syntax.Decorator;
public abstract class Beverage {
        public String description = "Unknown Beverage";

        public virtual String getDescription() {
                return description;
        }
        public abstract double cost();
}