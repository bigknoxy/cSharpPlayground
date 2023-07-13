namespace GoofingAround.Tests.Supporting
{
    internal class Person
    {
        public string Name  { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //need to implement these for comparison purposes
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Person otherPerson = (Person)obj;
            return Name == otherPerson.Name && Age == otherPerson.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }
    }
}