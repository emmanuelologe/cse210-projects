public class Word
{
    private string text;
    private bool Hidden;

    public Word(string text)
    {
        this.text = text;
        Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public override string ToString()
    {
        return Hidden ? "_____" : text;
    }

    public bool HiddenWord()
    {
        return Hidden;
    }
}
