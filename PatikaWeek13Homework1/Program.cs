namespace PatikaWeek13Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Teacher teacher = new Teacher()
           {
               FirstName="Gülay",
               LastName="Canlı"
           };

            ClassRoom classRoom = new ClassRoom(teacher);

            Console.WriteLine(classRoom.GetTeacherInfo());
            
        }
    }
}
