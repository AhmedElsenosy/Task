using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal static class StudentExtension
    {
        public static void SetNameScore (this List<Student> students, string name,double score)
        {
            students.Add(new Student { Name = name, Score = score });
        }
    }
}
