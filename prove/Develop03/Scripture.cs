using System;

class Scripture
{
    private List<Word> words;

    private Reference scriptureReference;

    public Scripture(Reference reference, string text)
    {
        scriptureReference = reference;
        words = new List<Word>();
        CreateWords(text);
    }

    private void CreateWords(string text)
    {
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }

    }

    public string GetScripture()
    {
        string scripture = "";
        foreach (Word word in words)
        {
            scripture += word.GetWord() + " ";
        }
        return scripture.TrimEnd();
    }

    public void Display()
    {
        Console.WriteLine(GetScripture());
        Console.WriteLine();
    }

    public bool HasWordsLeft()
    {
        foreach (Word word in words)
        {
            if (!word.GetIsHidden())
            {
                return true;
            }
        }
        return false;
    }

    public void RemoveWords()
    {
        int numWordsToRemove = new Random().Next(2, 4);
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, words.Count());
            if (words[rndIndex].GetIsHidden() == false)
            {
                words[rndIndex].SetIsHidden(true);
                wordsRemoved++;
            }

        } while (wordsRemoved != numWordsToRemove && this.HasWordsLeft());

    }
}