using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVotingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidate c1 = new Candidate("Dada", 60, "Baraur", "BJP", "Bangle");
            Candidate c2 = new Candidate("Lokesh", 35, "Madanput", "BJP", "Car");
            User u1 = new User("Pranshu", "Baraur", 25);
            User u2 = new User("Pran", "Baraur", 15);
            User u3 = new User("Nikki", "Baraur", 15);
            User u4 = new User("Nick", "Baraur", 17);
            Admin admin = new Admin();
            admin.RegisterCandidate(c2);
            admin.RegisterCandidate(c1);
            admin.RegisterUser(u1);
            admin.RegisterUser(u2);
            admin.RegisterUser(u3);
            admin.RegisterUser(u4);
            u1.GiveVote(c2);
            u2.GiveVote(c2);
            u3.GiveVote(c1);
            u4.GiveVote(c1);
            admin.DeclareWinner();
        }
    }
}
