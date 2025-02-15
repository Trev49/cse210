using System;

public class Word
{
    private string _Text;
    private List<bool> _IsHiddenLetter;

    public Word(string text, bool IsHidden)
    {
        _Text = text;
        _IsHiddenLetter = new List<bool>(_Text.Length);

        for (int i = 0; i < _Text.Length; i++)
        {
            _IsHiddenLetter.Add(IsHidden);
        }
    }

    public void SetLetterHidden(int index, bool isHidden)
    {
        if (index >= 0 && index < _IsHiddenLetter.Count)
        {
            _IsHiddenLetter[index] = isHidden;
        }
    }

    // Check if a letter is hidden or not
    public bool IsLetterHidden(int index)
    {
        if (index >= 0 && index < _IsHiddenLetter.Count)
        {
            return _IsHiddenLetter[index];
        }
        return false;
    }

    public string GetText()
    {
        return _Text;
    }

    public string GetDisplayContent()
    {
        string result = "";
        for (int i = 0; i < _Text.Length; i++)
        {
            result += IsLetterHidden(i) ? "_" : _Text[i].ToString();
        }
        return result;
    }

    public bool AllLettersHidden()
    {
        return _IsHiddenLetter.All(h => h);
    }


}