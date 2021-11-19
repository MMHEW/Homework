using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    class School
    {

        public static int students;
        public static int teachers;
        public static int janitors;
        public static int employees;
        public const int classes = 3;

        public School()
        {
            students = 0;
            teachers = 0;
            janitors = 0;
            employees = 0;
        }

        public static int getClasses()
        {
            return classes;
        }
        public static int getStudents()
        {
            return students;
        }
        public static int getEmployees()
        {
            return employees;
        }

        public static int getTeachers()
        {
            return teachers;
        }

        public static int getJanitors()
        {
            return janitors;
        }

        


}
}
