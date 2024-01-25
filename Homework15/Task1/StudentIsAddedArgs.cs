namespace Homework15.Task1
{
    internal class StudentIsAddedArgs : EventArgs
    {
        public readonly Student Student;
        public StudentIsAddedArgs(Student student) 
        {
            Student = student;
            Console.WriteLine($"Student {student.Name} {student.Surname} is added");
        }
    }
}
