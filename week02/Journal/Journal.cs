public class Journal
{
  //member variables or attributes--------------------

  public List<Entry> _entries = new List<Entry>();
  private string filePath = "journalNew.csv"; // file CSV

  //the methods---------------------------------------  
  public void AddEntry()
  {
    // Get and display a random prompt
    PromptGenerator generator = new PromptGenerator();
    string randomPrompt = generator.GetRandonPrompt();
    
    Console.WriteLine(randomPrompt);
    Console.Write("> ");
    string texEntry = Console.ReadLine();
    

    // time
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();

    string d1 = dateText;
    string d2 = randomPrompt;
    string d3 = texEntry;
    _entries.Add(new Entry(d1, d2, d3));
  }

  public void DisplayAll()
  {
    foreach ( var e in _entries)
    {
      e.Display();
      Console.WriteLine();
    }
  }
    
  public void SaveFile(string filename)
  {
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach (var e in _entries) //(Entry e in _entries)
      {

        outputFile.WriteLine($"{e._date} - prompt: {e._promptText}");
        outputFile.WriteLine(e._entryText);
        
      }
    }

  }

  public void LoadFromFile(string filename1)
  {
    string[] lines = System.IO.File.ReadAllLines(filename1);

    foreach (string line in lines)
    {
      Console.WriteLine(line);
    
    }
  }


  /*--------------------------------------------------------------------------
          Showing Creativity and Exceeding Requirements
    Improve the process of saving and loading to save as a .csv file that could be opened
     in Excel (make sure to account for quotation marks and commas correctly in your content. */     

   // Method to save all entries to CSV file
    public void AddEnCsv()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            
   // We write headers (Excel displays them as column titles)
            writer.WriteLine("Date,Prompt,Text");

            foreach (var e in _entries) 
            {
                writer.WriteLine(e.ToCsvFormat());
            }
        }
        Console.WriteLine($"Entries saved in {filePath}");
    }

    // Method to load all entries from CSV file
    public void LoadFromCsv()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("There is no CSV file to upload.");
            return;
        }

        _entries.Clear(); // Clear the list before loading

        string[] lineas = File.ReadAllLines(filePath);

        
        for (int i = 1; i < lineas.Length; i++)
        {
            var entry = Entry.FromCsvFormat(lineas[i]);
            if (entry != null)
            {
              Console.WriteLine(entry);
                
            }
        }

        Console.WriteLine("Entries loaded from CSV file.");
    }
  //-------------------------------------------------------------------------
}

