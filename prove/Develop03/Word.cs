class Word
{
    private string _text;
    public bool IsHidden { get; private set; }
    
    public Word(string text)
    {
        _text = text;
        IsHidden = false;
    }
    
    public void Hide()
    {
        IsHidden = true;
    }
    
    public string DisplayText()
    {
        return IsHidden ? "_____" : _text;
    }
}