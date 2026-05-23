public class Entry
{
    //member variables or attributes
    public string _date{ get; set; }
    public string _promptText{ get; set; }
    public string _entryText{ get; set; }


  //the methods
    public Entry(string d1, string d2, string d3)
    {
        _date = d1;
        _promptText = d2;
        _entryText = d3;
    }

    public void Display()
  {
    Console.WriteLine($"{_date} - prompt:{_promptText}");
    Console.WriteLine($"{_entryText} ");

  }  

    // ------------------------------------------------
     public override string ToString()
    {
        return $"{_date} - {_promptText} - {_entryText}";
    }

   
  // Converts the input to CSV format
    public string ToCsvFormat()
    {
    // Quotes are used to protect values ​​that have commas
        return $"\"{_date}\",\"{_promptText}\",\"{_entryText}\"";
    }

    // Create an entry from a CSV line
    public static Entry FromCsvFormat(string line)
    {
        string[] part = line.Split(',');
        if (part.Length == 3)
        {
            string d1 = part[0].Trim('"');
            string d2 = part[1].Trim('"');
            string d3 = part[2].Trim('"');
            return new Entry(d1, d2, d3);
        }
        return null;
    }


    //-------------------------------------------------
  
}