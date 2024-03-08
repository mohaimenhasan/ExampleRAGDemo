namespace ConsoleApp1
{
    public class Person
    {
        public static List<Person> CreateGroupOfPeople()
        {
            List<Person> people = new()
            {
                new Person("John", 25),
                new Person("Jane", 30),
                new Person("Joe", 35),
                new Person("Jill", 40),
                new Person("Jack", 45)
            };
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
