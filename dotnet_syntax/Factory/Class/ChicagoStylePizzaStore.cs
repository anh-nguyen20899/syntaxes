namespace dotnet_syntax.Factory;
public class ChicagoStylePizzaStore : PizzaStore 
{
    public override Pizza createPizza(String type) 
    {
        Pizza pizza = null;
        if (type.Equals("veggie")) {
        pizza = new ChicagoVeggiePizza();
        } else if (type.Equals("clam")) {
        pizza = new ChicagoClamPizza();
        } else {
            Console.WriteLine("There is no such kind in our Chicago store!");
            return null;
        }
        return pizza;
    }
}
