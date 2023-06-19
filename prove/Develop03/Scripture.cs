using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private string reference;
    private List<Word> words;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public string GetFormattedScripture()
    {
        return $"{reference}: {string.Join(" ", words.Select(w => w.IsHidden ? "____" : w.Text))}";
    }

    public void HideRandomWords()
    {
        Random random = new Random();

        foreach (Word word in words)
        {
            if (word.IsHidden)
                continue;

            if (random.Next(2) == 0)
                word.Hide();
        }
    }
}
