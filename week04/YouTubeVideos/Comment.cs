public class Comment
{
//member variables or attributes
  private string _text;
  private string _author;

  
    //the methods

     public Comment(string author, string text)
    {
        _text = text;
        _author = author;    
    }

     public void DiGetDisplayText()
    {
        Console.WriteLine($"- {_author}: {_text}");
    }
}
