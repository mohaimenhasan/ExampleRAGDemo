using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Team
    {
        private List<Person> people;

        public Team(List<Person> people)
        {
            this.people = people;
        }

        public IEnumerable<Person> GetTeammatesByAge(int minAge, int maxAge)
        {
            foreach (Person person in this.people)
            {
                if (person.Age >= minAge && person.Age <= maxAge)
                {
                    yield return person;
                }
            }
        }
    }
}
