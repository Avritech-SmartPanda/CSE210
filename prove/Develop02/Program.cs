using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Entry> entries = new List<Entry>();
        string[] prompts = new string[]{
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        string filename = "journal.txt";
        string input = "";
        while (input != "5")
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? (1-5): ");
            input = Console.ReadLine();
            Console.WriteLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Write a new entry");
                    Console.WriteLine();
                    Console.WriteLine("Prompt: " + prompts[new Random().Next(prompts.Length)]);
                    Console.Write("Entry: ");
                    string entry = Console.ReadLine();
                    entries.Add(new Entry(DateTime.Now.ToString(), prompts[new Random().Next(prompts.Length)], entry));
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine("Display the journal");
                    Console.WriteLine();
                    foreach (Entry journalEntry in entries)
                    {
                        Console.WriteLine(journalEntry);
                    }
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine("Save the journal to a file");
                    Console.WriteLine();
                    Console.Write("Enter a filename: ");
                    filename = Console.ReadLine();
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        foreach (Entry e in entries)
                        {
                            sw.WriteLine(e);
                        }
                    }
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine("Load the journal from a file");
                    Console.Write("Enter a filename: ");
                    filename = Console.ReadLine();
                    entries.Clear();
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("-");
                        string date = parts[0];
                        string[] answer = parts[1].Split("? ");
                        string prompt = answer[0];
                        string response = answer[1];
                        entries.Add(new Entry(date, prompt + "?", "\n" + response + "\n\n"));

                    }

                    foreach (Entry journalEntry in entries)
                    {
                        Console.WriteLine(journalEntry);
                    }
                    Console.WriteLine();
                    break;
                case "5":
                    Console.WriteLine("Quit");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid menu option");
                    Console.WriteLine();
                    break;

            }
        }
    }
}

class Entry
{
    public string date;
    public string prompt;
    public string entry;
    public Entry(string date, string prompt, string entry)
    {
        this.entry = entry;
        this.prompt = prompt;
        this.date = date;
    }
    public override string ToString()
    {
        return "Date: " + date + " - Prompt: " + prompt + " " + entry;
    }
}





