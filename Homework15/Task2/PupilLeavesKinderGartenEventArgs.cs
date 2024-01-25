using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15.Task2
{
    internal class PupilLeavesKinderGartenEventArgs : EventArgs
    {
        public readonly Pupil Pupil;

        public PupilLeavesKinderGartenEventArgs(Pupil pupil)
        {
            Pupil = pupil;
            Console.WriteLine($"Pupil {pupil} is leaving kindergarten");
        }
    }
}
