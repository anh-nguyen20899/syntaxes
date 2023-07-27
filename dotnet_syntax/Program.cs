using dotnet_syntax.Factory;


PizzaStore nyPizzaStore = new NYStylePizzaStore();
PizzaStore chicagoStore = new ChicagoStylePizzaStore();

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Anh ordered a chesse NY style Pizza");
nyPizzaStore.orderPizza("cheese");

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Tran ordered a pepperoni NY style Pizza");
nyPizzaStore.orderPizza("pepperoni");

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Joel ordered a clam Chicago style Pizza");
chicagoStore.orderPizza("clam");