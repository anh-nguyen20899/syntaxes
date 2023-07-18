    namespace dotnet_syntax.Observer;
    public class StatisticsDisplay : Observer, DisplayElement {
    private float temperature;
    private float humidity;
    private WeatherData weatherData;

    public StatisticsDisplay(WeatherData weatherData) {
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }

    public void update(float temperature, float humidity, float pressure) {
        this.temperature = temperature;
        this.humidity = humidity;
        display();
    }

    public void display() {
        Console.WriteLine("Statistics displays: " + temperature
            + "F degrees and " + humidity + "% humidity");
        }
    }