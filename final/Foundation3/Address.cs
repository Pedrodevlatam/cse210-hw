// Address class for managing event addresses
public class Address
{
    private string _street;
    private string _city;
    private string _zipCode;

    public Address(string street, string city, string zipCode)
    {
        _street = street;
        _city = city;
        _zipCode = zipCode;
    }

    // Method to get address details
    public string GetAddressDetails()
    {
        return $"{_street}, {_city}, {_zipCode}";
    }
}
