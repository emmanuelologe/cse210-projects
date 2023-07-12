using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<List<Word>> verses;

    public Scripture(string reference, string text)
    {
        RetriveReferencedScripture scriptureReference = new RetriveReferencedScripture(reference);
        InitializeVerses(scriptureReference, text);
    }

    private void InitializeVerses(RetriveReferencedScripture reference, string text)
    {
        verses = new List<List<Word>>();

        string[] verseTexts = text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

        for (int chapter = reference.StartChapter; chapter <= reference.EndChapter; chapter++)
        {
            int startVerse = (chapter == reference.StartChapter) ? reference.StartVerse : 1;
            int endVerse = (chapter == reference.EndChapter) ? reference.EndVerse : verseTexts.Length;

            List<Word> chapterVerses = new List<Word>();
            for (int verse = startVerse - 1; verse < endVerse; verse++)
            {
                string verseText = verseTexts[verse];
                string[] words = verseText.Split(' ');

                foreach (string word in words)
                {
                    chapterVerses.Add(new Word(word));
                }

                if (verse < endVerse)
                {
                    chapterVerses.Add(new Word("\n"));
                }
            }

            verses.Add(chapterVerses);
        }
    }

    public void HideWords()
    {
        List<Word> visibleWords = verses.SelectMany(verse => verse.Where(word => !word.HiddenWord())).ToList();

        if (visibleWords.Count == 0)
        {
            return;
        }

        Random random = new Random();
        int index = random.Next(visibleWords.Count);
        visibleWords[index].Hide();
    }

    public override string ToString()
    {
        return string.Join(" ", verses.SelectMany(verse => verse).Select(word => word.ToString()));
    }
}
