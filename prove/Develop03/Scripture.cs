using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Linq;


public class Scripture

{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private Random _random = new Random();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
     
       // Split the text into words, ignoring punctuation
        _words = text.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Select(wordText => new Word(wordText)).ToList();
        
        //Set up of the initial scripture and then keep looping through this.

        bool Done = IsCompletelyHidden();
        //If the scripture isn't completely hidden then keep going
        if (Done == false)  
        {
            //Hide 3 random words each time enter has been pushed
            HideRandomWords(3);
        
        }
  
    }
    private void HideRandomWords(int numberToHide)
    {
        //Used chat.gpt to create the code below because I couldn't figure it out
        var indices = new HashSet<int>();

        while (indices.Count < numberToHide)
        {
            int index = _random.Next(_words.Count);
            indices.Add(index);
        }
        foreach (int index in indices)
        {
            _words[index].Hide();
        }
        
    }
    public string GetDisplayText()
    {
        //I was needing help and gpt this info from chat.gpt
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));;
        return text;
    }
    public bool IsCompletelyHidden()
    {
        return false;
    }
  
}