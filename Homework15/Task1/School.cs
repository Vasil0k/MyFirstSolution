namespace Homework15.Task1
{
    internal class School
    {
        private List<Student> _students = [];
        public Director Director { get; set; }
        

        public School(Director director) 
        {
            Director = director;
            Director.StudentIsAdded += WelcomeParents;
        }

        public Student? FindStudent(Predicate<Student> filter)
        {
            return _students.Find(filter);
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
            Director.OnStudentAdded(new StudentIsAddedArgs(student));
        }

        private void WelcomeParents(object sender, StudentIsAddedArgs args)
        {
            Console.WriteLine($"Dear parent of {args.Student.Name} {args.Student.Surname}, your child is now student of our School.");
        }
    }
}
