using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15.Task2
{
    internal class Pupil
    {
        public String Name { get; init; }
        public String Surname { get; init; }

        public Pupil(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string? ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
