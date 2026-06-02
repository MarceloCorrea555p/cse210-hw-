using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

         List<Order> ordersList = new List<Order>();

         Order order1 = new Order("John Doe");
         
        
         // Agregar productos 1
         order1.AddProduct("Laptop", "LP1001", 999.99, 2);
         order1.AddProduct("Monitor", "LE4566", 55.99, 9);
         order1.AddProduct("Headphones", "OP380", 520.1, 1);
         order1.AddProduct("Smartphone", "SP2002", 499.99, 1);

         // Agregar productos 2
         Order order2 = new Order("Marcelo Correa");
         
         order2.AddProduct("Screws T", "t1855", 0.1, 100);
         order2.AddProduct("Monitor", "LE4566", 55.99, 2);
         order2.AddProduct("Hammer", "HM00145", 8.2, 8);
         order2.AddProduct("Shoes", "SP7744", 499.99, 6);
         order2.AddProduct("Screws A", "AT00012", 1.2, 150);

         order1.PackingLabel();

         order1.ShippingLabel("188 Main St", "Anytown", "CA", "USA");

         order2.PackingLabel();

         order2.ShippingLabel("232 Rincom", "Cordoba", "CB", "AR");
         
         /*// show results
         ordersList.Add(order1);
         ordersList.Add(order2);  


         foreach (var order in ordersList)
         {
            order.GetDisplayText();
            Console.WriteLine();
         }*/

    }


}