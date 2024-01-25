using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15.Task2
{
    internal class KinderGarten
    {
        private List<Pupil> _pupils = [];
        public event EventHandler<PupilLeavesKinderGartenEventArgs> ChildLeavesKinderGartenEvent;
        public School School { get; init; }

        public KinderGarten (School school)
        {
            this.School = school;
        }

        public void PupilGraduate(Pupil pupil)
        {
            if (_pupils.Remove(pupil))
            {
                Console.WriteLine($"Pupil {pupil} has graduated from kindergarten");
                School.OnPupilLeavesKindergarten(new PupilLeavesKinderGartenEventArgs(pupil));
            }
            else
            {
                Console.WriteLine("There is no such pupil in the kindergarten");
            }            
        }

        public void AddPupil(Pupil pupil)
        {
            _pupils.Add(pupil);
        }
    }
}
