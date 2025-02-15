using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;

public class Reference
{
    private string _Book;
    private int _Chapter;
    private int _StartVerse;
    private int _EndVerse;

    public Reference(string Book, int Chapter, int Verse)
    {
        _Book = Book;
        _Chapter = Chapter;
        _StartVerse = Verse;
        _EndVerse = Verse;

    }
    public Reference(string Book, int Chapter, int StartVerse, int EndVerse)
    {
        _Book = Book;
        _Chapter = Chapter;
        _StartVerse = StartVerse;
        _EndVerse = EndVerse;
    }
    public Reference(string referenceText)
    {
        string[] parts = referenceText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        _Book = parts[0];
        string[] verseParts = parts[1].Split(':');
        _Chapter = int.Parse(verseParts[0]);
        string[] verses = verseParts[1].Split('-');
        _StartVerse = int.Parse(verses[0]);
        _EndVerse = verses.Length > 1 ? int.Parse(verses[1]) : _StartVerse;
    }
    public string GetDisplayText()
    {
        return $"{_Book} {_Chapter}:{_StartVerse}-{_EndVerse}";
    }


}