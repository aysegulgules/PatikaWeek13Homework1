using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek13Homework1
{
    internal class ClassRoom
    {
        public readonly Teacher _teacher;
        public ClassRoom(Teacher teacher)
        {

            _teacher = teacher; 

        }

        public  string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
