using System;

static class ScriptureGenerator
{
    private static Random random = new Random();

    private static string[] bookOfMormonScriptures =
    {
        "1 Nephi 3:7", "2 Nephi 2:25", "Alma 32:21", "Helaman 5:12", "3 Nephi 17:5"
        // Here I can add more Book of Mormon scriptures as desiredsees
    };

    private static string[] bookOfMormonTexts =
    {
        "And it came to pass", "I will go and do", "Faith is not to have a perfect knowledge", "And it came to pass that they did pray", "And it came to pass that Jesus blessed them"
        // Here I can add more Book of Mormon scripture texts as desired
    };

    public static Scripture GenerateRandomScripture()
    {
        int index = random.Next(bookOfMormonScriptures.Length);
        string reference = bookOfMormonScriptures[index];
        string text = bookOfMormonTexts[index];

        return new Scripture(reference, text);
    }
}
