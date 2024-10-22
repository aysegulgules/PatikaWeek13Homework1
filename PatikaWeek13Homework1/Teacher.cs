using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek13Homework1
{
    internal class Teacher : IOgretmen
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetInfo()
        {
           return FirstName + " " + LastName;
        }
    }
}
