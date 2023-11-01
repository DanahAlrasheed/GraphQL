using GraphQL.IService;
using GraphQL.Models;


namespace GraphQL.Service
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < 10; i++)
            {    
                students.Add(new Student(){StudentId = i , Name = "Student" + i.ToString() , Roll = i});
            }
            return students;
        }
    }
}
