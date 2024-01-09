namespace Homework12.People
{
    internal class Person : IComparable<Person>
    {
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public Person(Gender gender, int age)
        {
            Gender = gender;
            Age = age;
        }

        public int CompareTo(Person? other)
        {
            if (other == null)
            {
                return 1;
            }

            int genderCompare = ((int) Gender).CompareTo((int)other.Gender);
            if (genderCompare == 0)
            {
                return Age.CompareTo(other.Age);
            } 

            return genderCompare;
        }

        public override string ToString()
        {
            return $"Person: [gender: {Gender}, age: {Age}]";
        }
    }
}
