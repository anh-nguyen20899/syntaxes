namespace dotnet_syntax.Factory;
public class SimplePizzaFactory 
{
    public Pizza createPizza(String type) 
    {
        Pizza pizza = null;
        if (type.Equals("cheese")) {
        pizza = new NYCheesePizza();
        } else if (type.Equals("pepperoni")) {
        pizza = new NYPepperoniPizza();
        } else if (type.Equals("clam")) {
        pizza = new ChicagoClamPizza();
        } else if (type.Equals("veggie")) {
        pizza = new ChicagoVeggiePizza();
        }
        return pizza;
    }
}
