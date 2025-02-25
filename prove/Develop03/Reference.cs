class Reference
{
    public string _book;
    public int _chapter;
    public int _startVerse;
    public int? _endVerse;
    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    
    public string GetReference()
    {
        return _endVerse.HasValue ?
            $"{_book} {_chapter}:{_startVerse}-{_endVerse}" :
            $"{_book} {_chapter}:{_startVerse}";
    }
}