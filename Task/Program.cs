namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            ScoreProcessor score = new ScoreProcessor();

            var student = new Student();

            students.SetNameScore("Ahmed Elsenosy",99);
            students.SetNameScore("Mohamed Ibrahim", 100);
            students.SetNameScore("Youssef Ashraf", 10);
            students.SetNameScore("Waleed Tantawy", 90);
            students.SetNameScore("Ahmed Elrweny", 60);
            students.SetNameScore("Ma7moud Sala7", 77);
            students.SetNameScore("Mohamed Yasser", 86);
            students.SetNameScore("Omar Elsenosy", 70);
            students.SetNameScore("Foaud Elsenosy", 44);


            Console.WriteLine("My Students");
            foreach (var stud in students)
            {
                Console.WriteLine($"Name:{stud.Name} Score:{stud.Score}");
            }

            Console.WriteLine("_________________________________________");
            score.Filter(students);
            score.PrintStudentList();
            Console.WriteLine("_________________________________________");
            Console.WriteLine($"Average Score = {score.CalculateAverageScore(students)}");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Top Scores");
            score.TopScorer(students);

        }
    }
}
