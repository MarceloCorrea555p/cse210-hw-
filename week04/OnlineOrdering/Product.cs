public class Product
{

//member variables or attributes
private string _nameProduct;
private string _id;
private double _price;
private int _quantity;

    //the methods
        public Product(string name,string id, double price, int quantity)
        {
            _nameProduct = name;
            _id = id;
            _price = price;
            _quantity = quantity;
        }
        
         public double CalculateLineTotal()
    {
        return _price * _quantity;
    }

        public void GetDisplayText()
        {
            
            Console.WriteLine($"Product name: {_nameProduct}, ID: {_id}");
            
            //Console.WriteLine($"Product name: {_nameProduct}, ID: {_id}, Price: ${_price}, Quantity: {_quantity}");
        }

        
}



