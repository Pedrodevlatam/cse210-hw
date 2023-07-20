
Event Planning Program

Description
This C# program demonstrates the concept of inheritance in object-oriented programming. It simulates an event planning company that organizes and markets different types of events. The program allows users to create events of three main types: Lectures, Receptions, and Outdoor Gatherings. Each event has common attributes such as Title, Description, Date, Time, and Address, as well as type-specific information.

Classes
Event: The base class representing a generic event. It contains common attributes and methods for all event types.

Lecture: A derived class representing lecture events. It inherits from the Event class and includes attributes for the speaker's name and capacity.

Reception: A derived class representing reception events. It inherits from the Event class and includes an attribute for RSVP email.

OutdoorGathering: A derived class representing outdoor gathering events. It inherits from the Event class and includes an attribute for the weather forecast.

Address: A separate class to manage event addresses. It contains attributes for street, city, and zip code.

Program Specifications
The program uses inheritance to avoid duplicating shared attributes and methods among event types.

Each member variable in the classes is declared as private, following the principles of encapsulation.

The program creates instances of each event type, sets their values, and generates marketing messages for each event, displaying the results on the screen.

How to Use
Clone or download the entire repository to your local machine.

Open the solution in Visual Studio or any C# IDE of your choice.

Build and run the program.

The program will create sample events of each type and display their details, including standard details, full details, and short descriptions.

You can modify the sample events in the Main() method of the Program.cs file to create your own events and test the output.