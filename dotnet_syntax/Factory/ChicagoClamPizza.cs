namespace dotnet_syntax.Factory;
public class ChicagoClamPizza : Pizza
{
    public ChicagoClamPizza()
    {
        name = "Chicago Style Deep Dish Cheese Pizza";
        dough = "Extra Thick Crust Dough";
        sauce = "Plum Tomato Sauce";
        toppings.Add("Shredded Mozzarella Cheese");
        Console.WriteLine("ChicagoClamPizza");
    }
    public void cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}