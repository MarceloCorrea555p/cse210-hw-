public class Customer
{

//member variables or attributes
private string _nameCustomer;
private Address _address;

//the methods
    public Customer(string name, string street, string city, string state, string country)
    {
        _nameCustomer = name;
        _address = new Address(street, city, state, country);
    }

    public void GetDisplayText()
    {
        Console.WriteLine($"Customer name: {_nameCustomer}");
        Console.WriteLine(_address.GetDisplayText());
    }

     public bool InUSA()
        {
             return _address.GetDisplayText().EndsWith("usa", StringComparison.OrdinalIgnoreCase);

        }
}