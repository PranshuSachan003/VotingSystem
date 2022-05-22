using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVotingSystem
{
    public class User
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
        private string address;
        private int id;
        private int age;

        public int Age
        {
            get { return age; }
        }
        private static int count = 1;

        public User(string name, string add, int age)
        {
            this.name = name;
            address = add;
            this.age = age;
            id = count;
            count++;
        }

        public void GiveVote(Candidate candidate)
        {
            candidate.AddVote(this);
        }      
    }
}
