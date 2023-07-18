namespace dotnet_syntax.Observer;
public interface Subject {
    // Both of these methods take an Observer as an argument
    public void registerObserver(Observer o);
    public void removeObserver(Observer o);
    public void notifyObservers();
}
