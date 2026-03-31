public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public bool LivesInUSA()
    {
        return _address.IsUSA();
    }

    // Encapsulation: hides Address details
    public string GetShippingAddress()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}