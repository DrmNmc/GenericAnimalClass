using System;

namespace clubMemberIndexer
{
    public class ClubMembers
    {
        public const int Size = 15;
        private string[] Members = new string[Size];
        public string ClubType { get; set; }
        public string ClubLocation { get; set; }
        public string MeetingDate { get; set; }

        // constructor
        public ClubMembers() { }

        //indexer get and set methods
        public string this[int index]
        {
            get { return Members[index]; }
            set { Members[index] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClubMembers club = new ClubMembers();
            club[0] = "Dylan Miller";
            club[1] = "Mylan Diller";
            club[2] = "Dilan Myler";
            club[3] = "Myldin Dyler";
            club[ClubMembers.Size - 1] = "Millen Dylar";
            club.ClubType = "Homework Club";
            club.ClubLocation = "Innovation Center";
            club.MeetingDate = "Every Monday at 4 PM";
            Console.WriteLine("Club Type: " + club.ClubType);
            Console.WriteLine("Club Location: " + club.ClubLocation);
            Console.WriteLine("Meeting Date: " + club.MeetingDate);
            Console.WriteLine("Members:");
            for (int i = 0; i < ClubMembers.Size; i++)
            {
                if (club[i] != null)
                {
                    Console.WriteLine(club[i]);
                }
            }
        }
    }
}
