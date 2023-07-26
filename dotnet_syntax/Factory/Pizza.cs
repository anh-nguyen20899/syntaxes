namespace dotnet_syntax.Factory;
public class Pizza 
{
    public Pizza()
    {

    }
    public void prepare()
    {
        Console.WriteLine("We are preparing");
    }
    public void bake()
    {
        Console.WriteLine("We are baking");
    }
    public void cut()
    {
        Console.WriteLine("We are cutting slices");
    }
    public void box()
    {
        Console.WriteLine("We are wrapping");
    }
}