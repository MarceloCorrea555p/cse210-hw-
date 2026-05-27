public class Scripture
{
    //member variables or attributes
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    //the methods
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
           // Lógica para separar el texto y llenar la lista _words
        string[] wordStrings = text.Split(' ');
        foreach (string wordStr in wordStrings)
        {
            _words.Add(new Word(wordStr));
        }
    }

      public void HideRandomWords()
    {
        Random random = new Random();
        int myRandom = random.Next(_words.Count); // Genera un índice entre 0 y miListaDePalabras.Count - 1
        
        _words[myRandom].Hide(); // Llama al método Hide() del objeto Word en el índice generado
    

    }

   public string GetDisplayText()
    {
        
    string fullText = "";
    foreach (Word word in _words)
    {
        fullText += word.GetDisplayText() + " ";
    }
    return fullText; 
   }
    public bool IsCompletelyHidden()
    {
        
        bool final;
        foreach (Word word in _words)
        {
        
        
            bool valor = word.IsHidden();
            if (valor == false) 
            {
                
                return final = false; /*todo ----*/
            }
            
        }
        
        return final = true;
    }
    
}