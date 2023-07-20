This exercise tracker app is a C# program designed to help users track their different exercise activities, including running, cycling, and swimming. The app provides a unified interface for users to enter the date, length of activity in minutes, and specific details for each type of activity. It then calculates and displays relevant information, such as distance, speed, and pace, based on the user's input.

Features:

Polymorphism and Inheritance: The program uses inheritance and polymorphism to create a base class Activity and derived classes RunningActivity, CyclingActivity, and SwimmingActivity. This design ensures code reusability and allows for a unified interface to interact with different types of activities.

Encapsulation: The program follows the principle of encapsulation by making member variables private and providing public methods to access and modify the data. This protects the data from unauthorized access and ensures proper data handling.

Method Overriding: The base class Activity contains virtual methods GetDistance(), GetSpeed(), and GetPace(). Each derived class overrides these methods to provide specialized implementations specific to the type of activity, demonstrating the use of polymorphism.

How to Use:

Clone the repository to your local machine.

Open the solution file in Visual Studio or your preferred C# IDE.

Navigate to the Program.cs file, which contains the main program logic.

Inside the Main() method, you can create instances of each activity type, specifying the date, length in minutes, and any additional parameters relevant to the activity (e.g., distance, speed, laps).

Add each activity to the activities list.

Run the program. It will iterate through the activities list, calculate and display the summary information for each activity, including date, type, length, distance, speed, and pace.

Math Hints:

The program uses the following formulas to calculate activity details:

Distance (km) = Swimming laps * 50 / 1000
Speed (kph) = Distance / Minutes * 60
Pace (min per km) = Minutes / Distance