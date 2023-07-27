namespace dotnet_syntax.Factory;
public class Pizza 
{
    public String name;
    public String dough;
    public String sauce;
    public List<String> toppings = new List<String>();

    public Pizza()
    {

    }
    public void prepare()
    {
        Console.WriteLine("We are preparing " + name);
        foreach(var topping in toppings)
        {
            Console.WriteLine("+ " + name);
        }
    }
    public void bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }
    public void cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }
    public void box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }
}