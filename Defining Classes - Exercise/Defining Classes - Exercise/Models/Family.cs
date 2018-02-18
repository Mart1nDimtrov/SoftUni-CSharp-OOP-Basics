using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Exercise.Models
{
    public class Family
    {
        private List<Person> members;

        public Family ()
        {
            members = new List<Person>();
        }

        public void AddMember(string name, int age)
        {
            Person per = new Person(name, age);
            this.members.Add(per);
        }

        public Person GetOldestMember()
        {
            return this.members
                        .OrderByDescending(p => p.Age)
                        .FirstOrDefault();
        }
    }
}
