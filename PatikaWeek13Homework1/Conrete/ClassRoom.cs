namespace PatikaWeek13Homework1.Conrete
{
    internal class ClassRoom
    {
        public readonly Teacher _teacher;
        public ClassRoom(Teacher teacher)//Dependency Injection 
        {

            _teacher = teacher;

        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
