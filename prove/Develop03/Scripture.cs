class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    
    public void HideRandomWords()
    {
        int wordsToHide = 3;
        for (int i = 0; i < wordsToHide; i++)
        {
            List<Word> visibleWords = _words.Where(w => !w.IsHidden).ToList();
            if (visibleWords.Count == 0) break;
            visibleWords[_random.Next(visibleWords.Count)].Hide();
        }
    }
    
    public bool Hidden()
    {
        return _words.All(w => w.IsHidden);
    }
    
    public string DisplayText()
    {
        return $"{_reference.GetReference()}\n" + string.Join(" ", _words.Select(w => w.DisplayText()));
    }
}