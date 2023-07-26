namespace dotnet_syntax.Decorator;
public abstract class Beverage {
        public String description = "Unknown Beverage";

        public virtual String getDescription() {
                return description;
        }
        public abstract double cost();
}
// Normal Expresso
// Beverage beverage = new Espresso();
//  Console.WriteLine(beverage.getDescription() + " $" + beverage.cost());

// // A darkroast with double mocha and whip
//  Beverage beverage2 = new DarkRoast();
//  beverage2 = new Mocha(beverage2);
// Console.WriteLine(beverage2.getDescription() + " $" + beverage2.cost());