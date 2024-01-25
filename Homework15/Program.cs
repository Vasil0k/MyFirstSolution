using Homework15.Task1;
using Homework15.Task2;

namespace Homework15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Task1.School school = new(new Director());
            school.AddStudent(new Student("Ivan", "Petrov"));

            //Task 2
            KinderGarten kinderGarten = new(new Task2.School());
            Pupil pupil = new Pupil("Ivan", "Petrov");
            kinderGarten.AddPupil(pupil);
            kinderGarten.PupilGraduate(pupil);
        }
    }
}
