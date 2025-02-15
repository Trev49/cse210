using System;

public class Scripture
{
    private List<Word> _words;
    private Reference _ref;

    public Scripture(Reference refer, string text)
    {
        _ref = refer;
        // This breaks down the verse into individual words to choose what ones to hide
        _words = text.Split(' ').Select(word => new Word(word, false)).ToList();

    }
    public void HideRandomWords(int NumberToHide)
    {
        Random rand = new Random();
        int hideCount = 0;

        // List to track the words and letters we have already hidden
        List<int> hiddenLetters = new List<int>();

        while (hideCount < NumberToHide)
        {
            // Select a random word index
            int wordIndex = rand.Next(_words.Count);
            Word selectedWord = _words[wordIndex];

            int letterIndex = rand.Next(selectedWord.GetText().Length);

            if (!selectedWord.IsLetterHidden(letterIndex))
            {
                selectedWord.SetLetterHidden(letterIndex, true);
                hideCount++;
            }
        }
    }

    public bool AllHidden()
    {
        return _words.All(w => w.AllLettersHidden());
    }

    public string GetDisplayContent()
    {
        return string.Join(" ", _words.Select(w => w.GetDisplayContent()));
    }

}