using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class ScoreCriteria
    {
        public delegate bool StudentFilterDelegate(Student student);

        public List<Student> students = new List<Student>();

        //public ScoreCriteria()
        //{
        //    students.Add(new Student("Ahmed Elsenosy",99));
        //    students.Add(new Student("Mohamed Ibrahim", 100));
        //    students.Add(new Student("Youssef Ashraf", 10));
        //    students.Add(new Student("Waleed Tantawy", 90));
        //    students.Add(new Student("Ahmed Elrweny", 60));
        //    students.Add(new Student("Ma7moud Sala7", 77));
        //    students.Add(new Student("Mohamed Yasser", 86));
        //    students.Add(new Student("Omar Elsenosy", 70));
        //    students.Add(new Student("Foaud Elsenosy", 44));
        //}

        public void StudentFilter(StudentFilterDelegate filterDelegate)
        {
            foreach (var student in students)
            {
                if (filterDelegate(student))
                {
                    Console.WriteLine(student.Name);
                }
            }
        }
    }
}
