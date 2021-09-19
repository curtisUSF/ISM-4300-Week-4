//Curtis Evans
//Election

using System;
using System.Collections.Generic;
using System.Linq;

namespace Election
{
    class Program
    {
        static void Main(string[] args)
        {

  
            //dictonary for candidate name and party
            Dictionary<string, string> candidates = new Dictionary<string, string>();
          

            int n = int.Parse(Console.ReadLine());

            //inputting name and party for (n)
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string party = Console.ReadLine();
                candidates.Add(name, party);
            }

           
            //ballot Dictionary
            Dictionary<string, int> ballots = new Dictionary<string, int>();


            foreach (KeyValuePair<string, string> candidate in candidates)
            {

                ballots.Add(candidate.Key, 0);

            }


            //# of ballots
            int m = int.Parse(Console.ReadLine());

            //inputting ballots
            for (int i = 0; i < m; i++)
            {
                string nameOnBallot = Console.ReadLine();

                if (candidates.ContainsKey(nameOnBallot))
                    ballots[nameOnBallot] = ballots[nameOnBallot] + 1;
            }


            //find highest # of votes
            int voteMax = ballots.Values.Max();

            //variables
            int countWinners=0;
            string winner = "";
            string winningParty = "";

            foreach (KeyValuePair<string, int> ballot in ballots)
            {

                if (ballot.Value == voteMax)
                {
                    countWinners += 1;
                    winner = ballot.Key;
                }

                else
                    continue;

            }


            //if countWinners more than 1 then tie
            if (countWinners == 1)
            {
                winningParty = candidates[winner];
                Console.WriteLine(winningParty);
            }

            else if (countWinners > 1)
                Console.WriteLine("tie");


        }
    }
}
