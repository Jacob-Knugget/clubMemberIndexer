using System;
namespace clubIndexer
{
    class Program
    {
        public const int Size = 15;  // global variable
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = "";
                ClubLocation = "";
                MeetingDate = "";
            }
            //indexer get and set methods
            public string this[int index]
            {
                get
                {
                    string tmp;

                    if (index >= 0 && index <= Size - 1)
                    {
                        tmp = Members[index];
                    }
                    else
                    {
                        tmp = "";
                    }

                    return (tmp);
                }
                set
                {
                    if (index >= 0 && index <= Size - 1)
                    {
                        Members[index] = value;
                    }
                }

            }
        }
        public static void Main(string[] args)
        {
            ClubMembers premiumMembers = new ClubMembers();
            while(true)
            {
                int sub = 0;
                while (sub < 1 || sub > Size)
                {
                    Console.WriteLine($"Which club member would you like to enter (enter 1-{Size})?");
                    while (!int.TryParse(Console.ReadLine(), out sub))
                        Console.WriteLine($"Enter a value between 1-{Size}");
                }
                Console.WriteLine("Enter the name of the club member");
                premiumMembers[sub - 1] = Console.ReadLine();
                Console.WriteLine("Press any key to continue, q to stop");
                string stop = Console.ReadLine();
                if (stop == "q")
                    break;
            }
            premiumMembers.ClubType = "Gaming";
            premiumMembers.ClubLocation = "Tabernacle Church";
            premiumMembers.MeetingDate = "Wednesday 8-12pm";

            Console.WriteLine($"\nHere is information on the club:");
            Console.WriteLine($"Premium Members:");
            for (int i = 0; i < Size; i++)
            {
                if (premiumMembers[i] != string.Empty)
                    Console.WriteLine(premiumMembers[i]);
            }
            Console.WriteLine($"\nType: {premiumMembers.ClubType}");
            Console.WriteLine($"Location: {premiumMembers.ClubLocation}");
            Console.WriteLine($"Date: {premiumMembers.MeetingDate}");
        }
    }
}