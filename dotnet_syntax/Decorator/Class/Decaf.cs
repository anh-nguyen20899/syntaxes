namespace dotnet_syntax.Decorator;

public class Decaf : Beverage {
 public Decaf() {
  this.description = "Decaf";
 }

 public override double cost() {
 return 1.05;
 }

}