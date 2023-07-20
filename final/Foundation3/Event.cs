using System;

// Base Event class
public class Event
{
    // Private member variables (attributes)
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    // Constructor
    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Method to generate standard event details
    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.ToString(@"hh\:mm")}\nAddress: {_address.GetAddressDetails()}";
    }

    // Method to generate full event details
    public virtual string GetFullDetails()
    {
        return GetStandardDetails(); // Base class only provides standard details
    }

    // Method to generate short event description
    public virtual string GetShortDescription()
    {
        return $"Type: Event\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}
