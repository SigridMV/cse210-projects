using System;

class Reference
{
    private string book, chapter, verseStart, verseEnd, text;

    public Reference(string _book, string _chapter, string _verse, string _text)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _verse;
        verseEnd = _verse;
        text = _text;
    }

    public Reference(string _book, string _chapter, string _verseStart, string _verseEnd, string _text)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _verseStart;
        verseEnd = _verseEnd;    
        text = _text;   
    }

    public string GetReference()
    {
        if (verseStart == verseEnd)
        {
            return $"{book} {chapter}: {verseStart} \n{text}";
        }
        else
        {
            return $"{book} {chapter}: {verseStart}-{verseEnd} \n{text}";
        }
    }
}