using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVotingSystem
{
    public class Admin
    {
        static List<User> users = new List<User>();
        static List<Candidate> candidates = new List<Candidate>();

        public void RegisterUser(User user)
        {
            if (user.Age < 18)
            {
                Console.WriteLine("{0} - {1}", user.Name, user.Age);
                Console.WriteLine("You are not eligible");
            }
            else
            {
                users.Add(user);
                Console.WriteLine("{0} is voter", user.Name);
            }
        }

        public void RegisterCandidate(Candidate candidate)
        {
            candidates.Add(candidate);
            Console.WriteLine("Candidate {0} have registered", candidate.Name);
        }

        public bool ValidateUser(User user)
        {
            if (users.Contains(user))
            {
                return true;
            }
            return false;
        }

        public void DeclareWinner()
        {
            int max = -1;
            Candidate winner = null;
            foreach (var candidate in candidates)
            {
                if (candidate.NoOfVotes() > max)
                {
                    max = candidate.NoOfVotes();
                    winner = candidate;
                }
                else if(candidate.NoOfVotes() == max)
                {
                    if (candidate.Age > winner.Age)
                        winner = candidate;
                }
            }
           
            Console.WriteLine("Winner is {0} and gets {1}", winner.Name, winner.NoOfVotes());
        }
    }
}
