public class Program
{
    public static void Main()
    {
        // Creating products
        Product laptop = new Product("Laptop", 1001, 2000, 1);
        Product mouse = new Product("Mouse", 2002, 25, 2);
        Product keyboard = new Product("Keyboard", 3003, 40, 3);

        // Creating addresses
        Address address1 = new Address("123 Main Street", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Broad Street", "Sometown", "NY", "USA");
        Address address3 = new Address("789 Avenue Street", "Cityville", "BC", "Canada");

        // Creating customers
        Customer customer1 = new Customer("Pedro Mendieta", address1);
        Customer customer2 = new Customer("kathy Buitrago", address2);
        Customer customer3 = new Customer("Juan Perez", address3);

        // Creating orders
        List<Product> order1Products = new List<Product> { laptop, mouse };
        Order order1 = new Order(customer1, order1Products);

        List<Product> order2Products = new List<Product> { mouse, keyboard };
        Order order2 = new Order(customer2, order2Products);

        List<Product> order3Products = new List<Product> { laptop, keyboard };
        Order order3 = new Order(customer3, order3Products);

        // Displaying outcomes
        DisplayOrderDetails("Order 1:", order1);
        DisplayOrderDetails("Order 2:", order2);
        DisplayOrderDetails("Order 3:", order3);
    }

    public static void DisplayOrderDetails(string orderTitle, Order order)
    {
        Console.WriteLine(orderTitle);
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}\n");
    }
}
