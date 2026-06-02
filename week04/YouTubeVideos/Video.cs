public class Video
{

//member variables or attributes
private string _title;
private string _author;
private int _length;
private List<Comment> _comments = new List<Comment>();

 //the methods
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
     // Method for adding comments
       public void AddComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        _comments.Add(newComment);
    }

     public void GetDisplayText()
    {
        Console.WriteLine($"Video title: {_title}, Author: {_author}, Duration in seconds: {_length}s");
        Console.WriteLine($"Comments: ({_comments.Count}):");

        foreach (Comment c in _comments)
        {
            c.DiGetDisplayText();
        }
        
    }
}




      
        




