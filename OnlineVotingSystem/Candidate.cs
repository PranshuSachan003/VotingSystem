using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVotingSystem
{
    public class Candidate
    {
        List<User> voters = new List<User>();
        private string name;

        public string Name
        {
            get { return name; }
        }
        private int age;

        public int Age
        {
            get { return age; }
        }
        private string address;
        private string party;
        private string symbol;

        public Candidate(string name, int age, string add, string party, string sym)
        {
            this.name = name;
            this.age = age;
            address = add;
            this.party = party;
            symbol = sym; 
        }

        public void AddVote(User user)
        {
            if(new Admin().ValidateUser(user))
            voters.Add(user);
        }

        public int NoOfVotes()
        {
            return voters.Count;
        }
    }
}
