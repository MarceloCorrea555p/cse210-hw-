public class Order
{

//member variables or attributes
private string _customer;
private List<Product> _products  = new List<Product>();
    
    
    //the methods
        public Order(string customer)
        {
            _customer = customer;
        }
        // Method for adding products
        public void AddProduct(string name,string id, double price, int quantity)
        {
            Product newProduct = new Product(name, id, price, quantity);
            _products.Add(newProduct);
        }

        // Method for generating packing label
        public void PackingLabel()
        {
            System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------"); 
            Console.WriteLine($"Packing Label for {_customer}:");
            
            Console.WriteLine($"Products: ({_products.Count}):");
                
            foreach (Product p in _products)
            {
                p.GetDisplayText();
            }
            System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");

        } 

        // Method for generating shipping label
         public void ShippingLabel(string street, string city, string state, string country)
        {
            System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------"); 
            Console.WriteLine($"Shipping Label for {_customer}:");
            Customer customer = new Customer(_customer, street, city, state, country);
            customer.GetDisplayText();
            
            
            bool send= customer.InUSA();
            if (send)
            {

                Console.WriteLine("Shipping cost: $5.00");
                Console.WriteLine($"Grand Total: ${CalculateGrandTotal()+5}");
            }
            else
            {
                Console.WriteLine("Shipping cost: $35.00");
                Console.WriteLine($"Grand Total: ${CalculateGrandTotal()+35}");
            }


                       
            System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            
        }
        
         public double CalculateGrandTotal()
    {
        double total = 0;
        
        foreach (var product in _products)
        {
            // Llamamos al método interno del producto
            total += product.CalculateLineTotal();
        }
        
        return total;
    }

  
       
}