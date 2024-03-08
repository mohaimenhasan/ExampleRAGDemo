namespace ConsoleApp1
{
    public class Person
    {
        public static List<Person> CreateGroupOfPeople()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("John", 25));
            people.Add(new Person("Jane", 30));
            people.Add(new Person("Joe", 35));
            people.Add(new Person("Jill", 40));
            people.Add(new Person("Jack", 45));
            return people;
        }

        private Person(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        internal string Name { get; private set; }

        internal int Age { get; private set; }
    }
}
