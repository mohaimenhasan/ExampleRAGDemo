namespace ConsoleApp1
{
    public class Team
    {
        private List<Person> people;

        public Team(List<Person> people)
        {
            this.people = people;
        }

        // return the oldest person in the group
        public static Person GetOldestPerson(Team team)
        {
            List<Person> people = team.GetPeople();
            Person oldestPerson = people[0];
            foreach (Person person in people)
            {
                if (person.Age > oldestPerson.Age)
                {
                    oldestPerson = person;
                }
            }
            return oldestPerson;
        }

        internal List<Person> GetPeople()
        {
            return people;
        }
    }
}
