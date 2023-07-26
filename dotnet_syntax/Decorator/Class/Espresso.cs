namespace dotnet_syntax.Decorator;

public class Espresso : Beverage {
 public Espresso() {
  this.description = "Espresso";
 }

 public override double cost() {
 return 1.99;
 }

}