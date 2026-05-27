public class Word
{

    //member variables or attributes

       private string _text;
       private bool _isHidden;

    //the methods

     public Word(string text)
    {
        _text = text;
    
    }

   
  public void Hide()
    {
        string palabraConGuiones = "";

        for (int i = 0; i < _text.Length; i++)
        {
            palabraConGuiones += "_";
        }
        _text = palabraConGuiones;

        
        _isHidden = true;

    }
    public void Show()
    {
        string texx = GetDisplayText();
     Console.Write($"{texx} ");
    
    }
    public bool IsHidden()
    {
        
        bool finalHidden = _isHidden;
        return finalHidden;
              
    }
    
    public string GetDisplayText()
    {
            
            return _text;
        
    }
    
}