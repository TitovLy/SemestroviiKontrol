using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestroviiKontrol
{

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Dictionary<string, int> Grades { get; set; }

        public Student()
        {
            Grades = new Dictionary<string, int>();
        }
    }

}