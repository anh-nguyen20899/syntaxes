namespace dotnet_syntax.Observer;

public interface Observer {
    // get Notification from Subject via update method
    public void update(float temp, float humidity, float pressure);
}