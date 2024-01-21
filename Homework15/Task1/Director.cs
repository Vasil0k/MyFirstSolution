using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15.Task1
{
    internal class Director
    {
        public event EventHandler<StudentIsAddedArgs> StudentIsAdded;
        public void OnStudentAdded(StudentIsAddedArgs args)
        {
            StudentIsAdded?.Invoke(this, args);         
        }
    }
}
