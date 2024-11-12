using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class ScoreProcessor
    {
        public List<Student> PassingStudents = new List<Student>();
        public List<Student> FailingStudents = new List<Student>();
        ScoreCriteria score = new ScoreCriteria();

        public void Filter (List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.Score >= 50)
                    PassingStudents.Add(student);
                else 
                    FailingStudents.Add(student);
                
            }
        }

        public void PrintStudentList()
        {
            Console.WriteLine("Passing Students");
            foreach(Student student in PassingStudents)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("\nFailing Students");

            foreach(Student student1 in FailingStudents)
            {
                Console.WriteLine(student1.Name);
            }
        }

        public double CalculateAverageScore(List<Student>students)
        {
            double averageScore = 0;

            foreach (Student student in students)
            {
                averageScore += student.Score;
            }
            return averageScore/students.Count;
        }

        public void TopScorer(List<Student> students)
        {
            students.Sort((x,y) => x.Score.CompareTo(y.Score));
            students.Reverse();

            foreach(var stud in students)
            {
                Console.WriteLine($"Student name is {stud.Name} && Student score is {stud.Score}");
            }
            
            
        }



    }
}
