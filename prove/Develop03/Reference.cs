public class RetriveReferencedScripture
{
    public string Book { get; }
    public int StartChapter { get; }
    public int StartVerse { get; }
    public int EndChapter { get; }
    public int EndVerse { get; }

    public RetriveReferencedScripture(string reference)
    {
        string[] parts = reference.Split(':');
        Book = parts[0];

        string[] verseParts = parts[1].Split('-');

        string[] startVerseParts = verseParts[0].Split('.');
        StartChapter = int.Parse(startVerseParts[0]);
        StartVerse = startVerseParts.Length > 1 ? int.Parse(startVerseParts[1]) : 1;

        if (verseParts.Length > 1)
        {
            string[] endVerseParts = verseParts[1].Split('.');
            EndChapter = int.Parse(endVerseParts[0]);
            EndVerse = endVerseParts.Length > 1 ? int.Parse(endVerseParts[1]) : 1;
        }
        else
        {
            EndChapter = StartChapter;
            EndVerse = StartVerse;
        }
    }

    public override string ToString()
    {
        if (StartChapter == EndChapter && StartVerse == EndVerse)
        {
            return $"{Book} {StartChapter}:{StartVerse}";
        }
        else
        {
            return $"{Book} {StartChapter}:{StartVerse}-{EndChapter}:{EndVerse}";
        }
    }
}
