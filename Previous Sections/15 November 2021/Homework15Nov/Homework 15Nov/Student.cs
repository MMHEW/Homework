using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_15Nov
{
    internal class Student
    {
        public List<string> _students = new List<string> { };
        public Dictionary<string, int> _studentGrades = new Dictionary<string, int> { };
        public Student()
        {
            BuildListnDict();
            

        }
        private void BuildListnDict()
        {
            _students.Add("Timothy");
            _students.Add("John");
            _students.Add("Jim");
            _students.Add("Mike");
            _students.Add("Tony");

            _studentGrades.Add("Timothy",70);
            _studentGrades.Add("John",94);
            _studentGrades.Add("Jim",97);
            _studentGrades.Add("Mike",75);
            _studentGrades.Add("Tony",24);
        }
    }
}
