// Derived class for Reception events
public class Reception : Event
{
    private string _rsvpEmail;

    // Constructor
    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // Override method to provide full event details for Reception
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}
