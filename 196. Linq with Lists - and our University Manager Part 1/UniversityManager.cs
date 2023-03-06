using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _196._Linq_with_Lists___and_our_University_Manager_Part_1
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager() 
        {
            universities= new List<University>();
            students= new List<Student>();

            // add universities
            universities.Add(new University { Id = 1, Name = "UGM" });
            universities.Add(new University { Id = 2, Name = "UNY" });

            // add students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityID = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityID = 1 });
            students.Add(new Student { Id = 3, Name = "Siti", Gender = "female", Age = 19, UniversityID = 1 });
            students.Add(new Student { Id = 4, Name = "Bambang", Gender = "trans-gender", Age = 25, UniversityID = 1 });
            students.Add(new Student { Id = 4, Name = "Yongkru", Gender = "trans-gender", Age = 30, UniversityID = 1 });
            students.Add(new Student { Id = 5, Name = "Yanti", Gender = "female", Age = 22, UniversityID = 1 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student; ;
            Console.WriteLine("Male students");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student; ;
            Console.WriteLine("Female students");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void TransGenderStudents()
        {
            IEnumerable<Student> transGenderStudents = from student in students where student.Gender == "trans-gender" select student; ;
            Console.WriteLine("TransGender students");
            foreach (Student student in transGenderStudents)
            {
                student.Print();
            }
        }

    }
}
