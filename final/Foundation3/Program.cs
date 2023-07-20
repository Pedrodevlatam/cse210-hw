using System;

public class Program
{
    public static void Main()
    {
        // Creating Address objects
        Address lectureAddress = new Address("123 Lecture Street", "Whoville", "12345");
        Address receptionAddress = new Address("456 Reception Avenue", "Narnia", "67890");
        Address gatheringAddress = new Address("789 Gathering Road", "Smallville", "54321");

        // Creating Event objects for each type
        Event lectureEvent = new Lecture("Educational Talk", "A talk about interesting topics.", new DateTime(2023, 7, 20), new TimeSpan(18, 30, 0), lectureAddress, "John Doe", 100);
        Event receptionEvent = new Reception("Networking Night", "An evening of networking and socializing.", new DateTime(2023, 7, 25), new TimeSpan(19, 0, 0), receptionAddress, "rsvp@example.com");
        Event gatheringEvent = new OutdoorGathering("Picnic in the Park", "Enjoy a relaxing picnic with friends and family.", new DateTime(2023, 7, 30), new TimeSpan(12, 0, 0), gatheringAddress, "Sunny with a slight breeze.");

        // Generating and outputting marketing messages for each event
        Console.WriteLine("----- Event 1 -----");
        Console.WriteLine("Standard Details:\n" + lectureEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + lectureEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + lectureEvent.GetShortDescription());

        Console.WriteLine("\n----- Event 2 -----");
        Console.WriteLine("Standard Details:\n" + receptionEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + receptionEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + receptionEvent.GetShortDescription());

        Console.WriteLine("\n----- Event 3 -----");
        Console.WriteLine("Standard Details:\n" + gatheringEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + gatheringEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + gatheringEvent.GetShortDescription());
    }
}
