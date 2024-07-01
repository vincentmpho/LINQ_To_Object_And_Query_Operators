using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_To_Object_And_Query_Operators
{
    public class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        //Constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //Add some universities
            universities.Add(new University { Id=1, Name="UJ"});
            universities.Add(new University { Id=2, Name="UCT"});
            universities.Add(new University { Id=3, Name= "Wits"});

            //Add some Students
            students.Add(new Student { Id=1, Name="Mpho", Gender="Male",Age=17, UniversityId=1});
            students.Add(new Student { Id=2, Name="Vuyiswa", Gender="Female",Age=35, UniversityId=3});
            students.Add(new Student { Id=2, Name="Child of Yah", Gender="trans-gender",Age=22, UniversityId=1});
            students.Add(new Student { Id=2, Name="Lunga", Gender="Male",Age=53, UniversityId=3});
            students.Add(new Student { Id=2, Name="Wolves", Gender="Male",Age=39, UniversityId=1});
            students.Add(new Student { Id=2, Name="Zambulo", Gender="Female",Age=66, UniversityId=3});
        }
        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students
                                                where student.Gender == "male"
                                                select student;

            Console.WriteLine("Male- Students: ");

            foreach(Student student in maleStudents)
            {
                student.ShowInfo();
            }
        }

        public void SortStudentsByAge ()
        {
            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            Console.WriteLine("Students sorted by Age:");

            foreach (Student student in sortedStudents)
            {
                student.ShowInfo();
            }
        }

        public void AllStudentFromUj()
        {
            IEnumerable<Student> bjtStudents = from student in students
                                               join University in universities on student.UniversityId 
                                               equals University.Id
                                               where University.Name =="UJ"
                                               select student;

            Console.WriteLine("Student from UJ");

            foreach(Student s in bjtStudents)
            {
                s.ShowInfo();
            }
        }
    }
}
