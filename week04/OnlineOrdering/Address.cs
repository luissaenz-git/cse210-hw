public class Address
{
    private string _postalAddress = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";

    public bool isInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }        
        else
        {
            return false;
        }
    }

    public void SetAddressInfo(string postalAddress, string city, string state, string country)
    {
        _postalAddress = postalAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string getCustomerAddress()
    {
        return _postalAddress + " "+ _city + " " + _state + " " + _country;
    }

}