using System;
using System.Collections.Generic;
using System.IO;

class Entry
{

    public string _prompt { get; set; }
    public string _response { get; set; }
    public string _date { get; set; }

    public void DisplayEntry()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"> {_response}");
        Console.WriteLine();
    }

    public string getEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}", _date, _prompt, _response);

    }
}