﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFive
{
    class Program
    {
        //Global Variables
        const string FORMAT_PRINT = "{0,-20}{1,-7}{2,-7}{3,-7}{4,-7}{5,-7}";

        static void Main(string[] args)
        {
            //Teams
            Team SligoRovers = new Team("Sligo Rovers");
            Team FinnHarps = new Team("Finn Harps");
            Team GalwayUnited = new Team("Galway United");
            Team DerryCity = new Team("Derry City");
            Team Dundalk = new Team("Dundalk");
            Team[] Teams = { SligoRovers, FinnHarps, GalwayUnited, DerryCity, Dundalk };

            //Process
            PrintData(Teams);

            SligoRovers.AddResult(Team.Result.Win);
            FinnHarps.AddResult(Team.Result.Lose);
            FinnHarps.AddResult(Team.Result.Draw);
            GalwayUnited.AddResult(Team.Result.Win);
            Dundalk.AddResult(Team.Result.Lose);

            PrintData(Teams);

            Array.Sort<Team>(Teams);
            Array.Reverse(Teams);
            PrintData(Teams);

            Console.ReadKey();
        }

        public static void PrintData(Team[] Teams)
        {
            Console.WriteLine("\n"+FORMAT_PRINT, "Team Name", "Points", "Wins", "Draws", "Loses", "Played");
            foreach (Team tm in Teams)
            {
                Console.WriteLine(FORMAT_PRINT, tm.TeamName, tm.Points, tm.NumberOfWins, tm.NumberOfDraws, tm.NumberOfLosses, tm.NumberOfGames);
            }
        }
    }
}
