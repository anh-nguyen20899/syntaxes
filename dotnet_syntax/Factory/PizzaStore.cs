namespace dotnet_syntax.Factory;
public abstract class PizzaStore {
    // SimplePizzaFactory factory;
    public PizzaStore() {
        // this.factory = factory;
    }
    public Pizza orderPizza(String type) {
        Pizza pizza;
        pizza = createPizza(type);
        pizza.prepare();
        pizza.bake();
        pizza.cut();
        pizza.box();
        return pizza;
    }
    public abstract Pizza createPizza(String type);

}