namespace dotnet_syntax.Observer;

// Publishers + Subscribers = Observer Pattern

public class WeatherData : Subject
{
    private List<Observer> observers;
    private float temperature;
    private float humidity;
    private float pressure;
    public WeatherData() {
        observers = new List<Observer>();
    }
    public void registerObserver(Observer o) 
    {
        observers.Add(o);
    }

    public void removeObserver(Observer o) 
    {
        observers.Remove(o);
    }

    public void notifyObservers() 
    {
        foreach (Observer observer in observers) {
            observer.update(temperature, humidity, pressure);
        }
    }
    public void measurementsChanged() {
        notifyObservers();
    }
    public void setMeasurements(float temperature, float humidity, float pressure) {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        measurementsChanged();
    }
//     WeatherData weatherData = new WeatherData();

// CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
// StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
// ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

// weatherData.setMeasurements(80, 65, 30.4f);
}