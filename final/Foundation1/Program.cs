using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Program: Abstraction with YouTube Videos");
        Console.WriteLine("Description: This program demonstrates the principle of abstraction by simulating a system to track YouTube videos and comments.");
        Console.WriteLine();

        // Create videos and add comments
        Video video1 = new Video("Cats Playing Piano", "PianoCatLover89", 180);
        video1.AddComment("CatLover123", "This video is purr-fect! I can watch it all day!");
        video1.AddComment("KeyboardWarrior", "Cats don't even know they're playing piano.");
        video1.AddComment("MusicEnthusiast22", "Beautiful melody, meow-sic to my ears!");

        Video video2 = new Video("How to Bake a Delicious Cake", "BakeMasterChef", 240);
        video2.AddComment("BakingQueen", "Thanks for the recipe! My cake turned out amazing!");
        video2.AddComment("FoodieAdventurer", "I wonder if I can substitute butter with avocado...");
        video2.AddComment("CakeHater2020", "Who even eats cake these days? Not healthy!");

        Video video3 = new Video("Extreme Sports Fails Compilation", "AdrenalineJunkie98", 150);
        video3.AddComment("FearlessDaredevil", "That skateboard fail was epic! Keep 'em coming!");
        video3.AddComment("CouchPotato99", "Why would anyone do this? I'll stick to watching TV.");
        video3.AddComment("SafetyFirst1", "These guys need to be more careful, seriously!");

        Video video4 = new Video("Cute Baby Animals Compilation", "AnimalLover2000", 300);
        video4.AddComment("PuppyPower", "Aww! My heart just melted from all the cuteness!");
        video4.AddComment("NotAnAnimalPerson", "Yeah, they're cute, but I prefer reptiles.");
        video4.AddComment("AnimalRightsActivist", "These videos should promote animal adoption.");

        // Create a list to store the videos
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.Length);
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
