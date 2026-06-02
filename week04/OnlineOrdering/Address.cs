using System.Collections.Concurrent;

public class Address
{

//member variables or attributes
private string _address1;

    //the methods
        public Address(string street, string city, string state, string country)
        {
           _address1 = $"{street}\n{city}\n{state}\n{country}";
        }

               

        public string GetDisplayText()
        {
            return $"Address: {_address1}";
        }
}