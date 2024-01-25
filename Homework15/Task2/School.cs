using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15.Task2
{
    internal class School
    {
        private List<Pupil> _pupils = [];
        public event EventHandler<PupilLeavesKinderGartenEventArgs> ChildLeavesKinderGartenEvent;


        public School() 
        {
            ChildLeavesKinderGartenEvent += WelcomeNewPupil;
        }

        public void OnPupilLeavesKindergarten(PupilLeavesKinderGartenEventArgs args)
        {
            ChildLeavesKinderGartenEvent?.Invoke(this, args);
        }

        private void WelcomeNewPupil(object sender, PupilLeavesKinderGartenEventArgs args)
        {
            Console.WriteLine($"Welcome to the school {args.Pupil}");
        }
    }
}
