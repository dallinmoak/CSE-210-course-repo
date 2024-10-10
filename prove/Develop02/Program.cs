using System;
using System.Globalization;

class Program
{
    class Entry
    {
        public Entry(string promptText, string response, string date)
        {
            this._promptText = promptText;
            this._response = response;
            this._date = date;
        }
        public string _promptText;
        public string _response;
        public string _date;
    }

    class Prompt
    {
        public Prompt()
        {
            //TODO: actually randomize from a list of prompt
            this._promptText = "What's on your mind?";
        }
        private string _promptText;
        public Entry PerformPrompt()
        {
            Console.WriteLine(this._promptText);
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString();
            return new Entry(this._promptText, response, date);
        }
    }

    class Journal
    {
        public Journal(string filesource)
        {
            this._entries = Load(filesource);
            this._formattedContents = FormatContents(this._entries);

        }
        private List<Entry> _entries;
        private string _formattedContents;
        public void DisplayContents()
        {
            Console.WriteLine(_formattedContents);
        }
        private static string FormatContents(List<Entry> entries)
        {
            string formattedContents = "";
            foreach (Entry entry in entries)
            {
                formattedContents += $"{entry._promptText} {entry._response} {entry._date}\n";
            }
            return formattedContents;
        }
        private static List<Entry> Load(string filesource)
        {
            //TODO: actually load stuff from the file
            return new List<Entry>{
                new Entry("promptText", "response", "date"),
                new Entry("promptText2", "response2", "date2")
            };
        }
        public void PerformPrompt()
        {
            Entry entry = new Prompt().PerformPrompt();
            Console.WriteLine($"adding entry: {entry._promptText} {entry._response} {entry._date}");
            this._entries.Add(entry);
            this._formattedContents = FormatContents(this._entries);
        }
        public void Save(string filesource)
        {
            // Save the contents to the file
        }
    }

    private static int ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string response = Console.ReadLine();
            if (!int.TryParse(response, out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            return choice;
        }
    }

    static void Main(string[] args)
    {
        Journal myJournal = null;
        int choice = 0;
        while (choice != 5)
        {
            choice = ShowMenu();
            bool loadError = false;
            bool choiceRequiresLoad = choice == 1 || choice == 2 || choice == 4;
            if (myJournal == null && choiceRequiresLoad)
            {
                loadError = true;
            }
            if (!loadError)
            {
                if (choice == 1)
                {
                    myJournal.PerformPrompt();
                }
                else if (choice == 2)
                {
                    myJournal.DisplayContents();
                }
                else if (choice == 3)
                {
                    Console.Write("what file would you like to load?");
                    string filesource = Console.ReadLine();
                    myJournal = new Journal(filesource);
                }
                else if (choice == 4)
                {
                    Console.Write("what file would you like to save to?");
                    string filesource = Console.ReadLine();
                    myJournal.Save(filesource);
                    Console.WriteLine("saved as " + filesource);
                }
                else if (choice == 5)
                {
                    Console.Write("Goodbye!");
                }
            }
        }
    }
}