namespace dotnet_syntax.Decorator;

public class DarkRoast : Beverage {
 public DarkRoast() {
    this.description = "DarkRoast";
 }
public override String getDescription() {
        return this.getDescription();
    }
 public override double cost() {
    return .99;
 }

}