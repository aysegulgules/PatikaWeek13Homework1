using PatikaWeek13Homework1.Abstract;

namespace PatikaWeek13Homework1.Conrete
{
    internal class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetInfo()
        {
            return FirstName + " " + LastName;
        }
    }
}
