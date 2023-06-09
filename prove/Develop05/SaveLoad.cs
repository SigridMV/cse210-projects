using System;
using System.Collections.Generic;

public class SaveLoad
{
    public SaveLoad()
    {

    }

    public void Save(List<Goals> MenuList)
    {
        Console.Write("Please entry the file name: ");

        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int i = 0;
            foreach (Goals entry in MenuList)
            {
                i += 1;
                outputFile.WriteLine(entry.SaveFormat());
            }
        }
        Console.WriteLine("File saved.");
    }

    public void Load(List<Goals> MenuList)
    {
        Console.Write("Please entry your file name: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return;
        }
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)

        {
            string[] parts = line.Split(":");
            if (parts[0] == "simpleGoals")
            {
                string[] parts2 = parts[1].Split(",");
                Simple simple = new Simple(parts2[0], parts2[1], int.Parse(parts2[2]), bool.Parse(parts2[3]));
                MenuList.Add(simple);

            }
            else if (parts[0] == "EternalGoals")
            {
                string[] parts2 = parts[1].Split(",");
                Eternal eternal = new Eternal(parts2[0], parts2[1], int.Parse(parts2[2]));
                MenuList.Add(eternal);

            }
            else if (parts[0] == "Checklist")
            {
                string[] parts2 = parts[1].Split(",");
                Checklist checklist = new Checklist(parts2[0], parts2[1], int.Parse(parts2[2]), int.Parse(parts2[3]), int.Parse(parts2[4]), int.Parse(parts2[5]));
                MenuList.Add(checklist);

            }
        }
        Console.WriteLine("File loaded.");
    }
}