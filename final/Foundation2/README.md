# Small Technology Products Ordering System

## Description

This C# program implements a small technology products ordering system for a company that sells products online. The program consists of classes for Product, Customer, Address, and Order, each responsible for specific functionalities.

The program allows users to create orders with products and customers, calculate the total cost of the order (including shipping), and generate packing and shipping labels.

## Classes and Responsibilities

1. **Product**
   - Attributes: Name, Product ID, Price, Quantity
   - Methods: CalculateTotalPrice() (to compute the total price of the product based on price and quantity)

2. **Customer**
   - Attributes: Name, Address (Address is an instance of the Address class)
   - Methods: IsInUSA() (to determine if the customer lives in the USA or not)

3. **Address**
   - Attributes: Street Address, City, State/Province, Country
   - Methods: IsInUSA() (to determine if the address is in the USA) and GetFullAddressString() (to return all address fields in one string)

4. **Order**
   - Attributes: Customer (an instance of the Customer class) and List of Products (a list of instances of the Product class)
   - Methods: CalculateTotalPrice() (to compute the total cost of the order), GetPackingLabel() (to generate a packing label string), and GetShippingLabel() (to generate a shipping label string)

## How to Use

1. Clone the repository or download the source code.

2. Open the solution file (.sln) in Visual Studio or your preferred C# IDE.

3. Compile and run the program.

4. The program will create three sample orders, each with three products. Two orders will have customers within the USA, and one order will have a customer outside the USA.

5. The program will display the packing label, shipping label, and total price for each order.

## Outcome Format

For each order, the program will display the following information:

Order 1:
Packing Label:
Product Name: Laptop, Product ID: 1001, Quantity: 1
Product Name: Mouse, Product ID: 2002, Quantity: 2

Order 1:
Packing Label:
Product Name: Laptop, Product ID: 1001, Quantity: 1
Product Name: Mouse, Product ID: 2002, Quantity: 2

Shipping Label:
Customer Name: Pedro Mendieta
123 Main Street
Anytown, CA
USA
Total Price: $2055,00

Order 2:
Packing Label:
Product Name: Mouse, Product ID: 2002, Quantity: 2
Product Name: Keyboard, Product ID: 3003, Quantity: 3

Shipping Label:
Customer Name: kathy Buitrago
456 Broad Street
Sometown, NY
USA
Total Price: $175,00

Order 3:
Packing Label:
Product Name: Laptop, Product ID: 1001, Quantity: 1
Product Name: Keyboard, Product ID: 3003, Quantity: 3

Shipping Label:
Customer Name: Juan Perez
789 Avenue Street
Cityville, BC
Canada
Total Price: $2155,00
## Notes

- The program enforces encapsulation by keeping member variables private and providing public methods for accessing and modifying the data. This ensures that the     internal details of the classes are hidden from external code.
- The classes use TitleCase for class names and _camelCase for private member variables to follow C# naming conventions.
- The provided outcome showcases the correct display of the packing label, shipping label, and total price for each order, taking into account the customer's location.

