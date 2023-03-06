using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _197._Sorting_and_Filtering_with_Linq
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            // add universities
            universities.Add(new University { Id = 1, Name = "UGM" });
            universities.Add(new University { Id = 2, Name = "UNY" });

            // add students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityID = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityID = 2 });
            students.Add(new Student { Id = 3, Name = "Siti", Gender = "female", Age = 19, UniversityID = 1 });
            students.Add(new Student { Id = 4, Name = "Bambang", Gender = "trans-gender", Age = 25, UniversityID = 2 });
            students.Add(new Student { Id = 4, Name = "Yongkru", Gender = "trans-gender", Age = 30, UniversityID = 1 });
            students.Add(new Student { Id = 5, Name = "Yanti", Gender = "female", Age = 22, UniversityID = 2 });
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

        public void SortByStudentAge()
        {
            var sortByStudentAge = from student in students orderby student.Age select student;
            Console.WriteLine("Sort By Student by Age");
            foreach (Student student in sortByStudentAge)
            {
                student.Print();
            }   
        }

        public void StudentFromUniversity(int uniName)
        {
            IEnumerable<Student> collectStudent = from student in students
                                           join university in universities on student.UniversityID equals university.Id
                                           where university.Id == uniName
                                           select student;

            Console.WriteLine($"Sort from {uniName}");

            foreach (Student student in collectStudent)
            {
                student.Print();
            }

        }


    }
}
