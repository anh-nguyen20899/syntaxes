namespace dotnet_syntax.Decorator;

public class HouseBlend : Beverage {
 public HouseBlend() {
  this.description = "HouseBlend";
 }

 public override double cost() {
 return .89;
 }

}