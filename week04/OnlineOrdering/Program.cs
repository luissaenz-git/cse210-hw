using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Customer customer1 = new Customer();
        Order order1 = new Order();
        order1.SetCustomer(customer1);
        
        Customer customer2 = new Customer();
        Order order2 = new Order();
        order2.SetCustomer(customer2);

        customer1.SetCustomerInfo("Josh Martin", "123 Main St", "Anytown", "CA", "USA");
        order1.SetCustomerOrder
        ("Tomato,KU121, 2.5, 3;"+ 
         "Bread, KU122, 1.5, 2;"+
         "Milk, KU123, 3.0, 1;" +
         "Eggs, KU124, 0.5, 12");

        customer2.SetCustomerInfo("Camila Romero", "1960 Copacabana St", "La Paz", "LPZ", "Bolivia");
        order2.SetCustomerOrder
        ("Nuggets, KU130, 5.3, 3;" +
         "Fries, KU131, 2.5, 2;" +
         "Soda, KU132, 1.0, 4;" +
         "Dr. Pepper, KU133, 3.0, 2");

        
        
        Console.WriteLine("Packing Label: " + order1.packingLabel() + "\n" + "Shipping Label: " + order1.shippingLabel() + "\n" + "Total Price Order: " + order1.totalCostOrder() + "$" + "\n");

        Console.WriteLine("Packing Label: " + order2.packingLabel() + "\n" + "Shipping Label: " + "\n" + order2.shippingLabel() + "\n" + "Total Price Order: " + order2.totalCostOrder() + "$" + "\n");
       


        
    }
}