using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioKart8_TrackPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Picker pick = new Picker();
            List <string> prevTracks = new List <string>();
            bool restart = true;
            bool firstRun = true;
            bool prevTrack = true;

            do
            {
                int trackID = -1;
                string response = "";
                string[] trackArr = new string[48] { "Mario Kart Stadium", "Mario Circuit", "Water Park", "Toad Harbor", "Sweet Sweet Canyon", "Twisted Mansion", "Thwomp Ruins", "Shy Guy Falls", "Moo Moo Meadows", "Dry Dry Desert", "Mario Circuit", "Donut Plains 3", "Cheep Cheep Beach", "Royal Raceway", "Toad's Turnpike", "DK Jungle", "Yoshi Circuit", "Wario's Goldmine", "Excitebike Arena", "Rainbow Road (SNES)", "Dragon Driftway", "Ice Ice Outpost", "Mute City", "Hyrule Circuit", "Sunshine Airport", "Dolphin Shoals", "Electrodome", "Mount Wario", "Cloudtop Cruise", "Bone-Dry Dunes", "Bowser's Castle", "Rainbow Road (Wii U)", "Tick-Tock Clock", "Piranha Plant Slide", "Grumble Volcano", "Rainbow Road (N64)", "Wario Stadium", "Sherbet Land", "Music Park", "Yoshi Valley", "Baby Park", "Cheese Land", "Wild Woods", "Animal Crossing", "Neo Bowser City", "Ribbon Road", "Super Bell Subway", "Big Blue" };

                Console.Clear();
                Console.WriteLine("──────────────██████");
                Console.WriteLine("──────────████▓▓▓▓▓▓██");
                Console.WriteLine("────────██▓▓▓▓▓▓▓▓▓▓▓▓██");
                Console.WriteLine("──────██▓▓▓▓▓▓████████████");
                Console.WriteLine("────██▓▓▓▓▓▓████████████████");
                Console.WriteLine("────██▓▓████░░░░░░░░░░░░██████");
                Console.WriteLine("──████████░░░░░░██░░██░░██");
                Console.WriteLine("──██░░████░░░░░░██░░██░░███");
                Console.WriteLine("██░░░░██████░░░░░░░░░░░░░░██");
                Console.WriteLine("██░░░░░░██░░░░██░░░░░░░░░░██");
                Console.WriteLine("──██░░░░░░░░░███████░░░░████");
                Console.WriteLine("────████░░░░░░░███████████");
                Console.WriteLine("──────██████░░░░░░░░░░██");
                Console.WriteLine("────────────██████████");


                Console.WriteLine();
                Console.WriteLine("%%%% MARIO KART 8 - RANDOM TRACK PICKER %%%%");

                if (firstRun == false)
                {
                    int tracksPlayed = 0;
                    Console.WriteLine();
                    Console.WriteLine("Tracks So Far:");
                    while (tracksPlayed < prevTracks.Count)
                    {
                        Console.WriteLine();
                        Console.WriteLine("{0}. {1}", tracksPlayed+1, prevTracks[tracksPlayed]);
                        tracksPlayed++;
                    }


                while (trackID < 0)
                    {
                        trackID = pick.checkTrack(prevTracks, trackArr);
                    }

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to begin...");
                    Console.ReadLine();
                    firstRun = false;
                    trackID = pick.getTrack();
                }

                prevTracks.Add(trackArr[trackID]);

                Console.WriteLine();
                Console.WriteLine("NEW TRACK SELECTED = {0}", trackArr[trackID]);
                Console.WriteLine();
                Console.WriteLine("Do you want to pick another track? Y = Yes | N = No");

                response = Console.ReadLine().ToLower();

                if (response == "yes" || response == "y" || response == "yeah")
                {
                    restart = true;
                }
                else
                {
                    restart = false;
                }

            } while (restart == true);
        }
    }

    class Picker
    {
        public int getTrack()
        {
            int trackno = 0;
            Random rnd = new Random();

            trackno = rnd.Next(48);

            return trackno;
        }

        public int checkTrack(List<string> prevTracks, string[] trackArr)
        {
            int trackID = 0;
            int i = 0;
            trackID = getTrack();

            for (i = 0; i < prevTracks.Count; i++)
            {
                if (prevTracks[i] == trackArr[trackID])
                {
                    return -1;
                }
            }

            return trackID;
        }
    }
}
