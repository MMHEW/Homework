using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    class Teacher : Employee
    {
        // Fields
        private int id;
        private static int randomNum;
        private string classes;
        static Random rnd = new Random();
        private static int userChoice;
        public static string getChosenClasses(int i)
        {


            Console.WriteLine($"Teacher {(i + 1)}Please chose which Course you teach \n 1) {Classes.Algebra} \n 2) {Classes.Geography} \n 3) {Classes.English}");

            userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1)
            {
                return $"{Classes.Algebra}";
            }
            else if (userChoice == 2)
            {
                return $"{Classes.Geography}";
            }
            else
            {
                return $"{Classes.English}";
            }

        }

        public void setClasses(string classes)
        {
            this.classes = classes;
        }

        public string getClasses()
        {
            return this.classes;
        }

        public static string getRandomClasses()
        {
            randomNum = rnd.Next(1, 4);
            if (randomNum == 1)
            {
                return $"{Classes.Algebra}";
            }
            else if (randomNum == 2)
            {
                return $"{Classes.Geography}";
            }
            else
            {
                return $"{Classes.English}";
            }
        }

        public Teacher(ref int employees, ref int teachers)
        {
            employees++;
            teachers++;
            this.id = employees;
        }

    }
}
