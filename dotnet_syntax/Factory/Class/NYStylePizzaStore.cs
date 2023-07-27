namespace dotnet_syntax.Factory;
public class NYStylePizzaStore : PizzaStore 
{
    public override Pizza createPizza(String type) 
    {
        Pizza pizza = null;
        if (type.Equals("cheese")) {
        pizza = new NYCheesePizza();
        } else if (type.Equals("pepperoni")) {
        pizza = new NYPepperoniPizza();
        } else {
            Console.WriteLine("There is no such kind in our New York store!");
            return null;
        }
        return pizza;
    }
}
