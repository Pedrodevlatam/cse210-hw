// Derived class for Outdoor Gathering events
public class OutdoorGathering : Event
{
    private string _weatherForecast;

    // Constructor
    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    // Override method to provide full event details for Outdoor Gathering
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }
}
