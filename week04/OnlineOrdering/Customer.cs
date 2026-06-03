public class Customer
{
    private string _name = "";
    private Address _address = new Address();

    public bool isInUSA()
    {
        return _address.isInUSA();
    }

    public string GetCustomerAddress()
    {
        return _name + " " +_address.getCustomerAddress();
    }

   public void SetCustomerInfo(string name, string postalAddress, string city, string state, string country)
    {
        _name = name;
        _address.SetAddressInfo(postalAddress, city, state, country);
    }
}