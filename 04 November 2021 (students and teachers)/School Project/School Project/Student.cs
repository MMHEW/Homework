using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    class Student
    {
        // Fields
        static Random rnd = new Random();
        private int id;
        private static int randomNum;
        private static int userChoice;
        // Constructor
        private string classes;
        
       // public Dictionary<string, string> aDict = new Dictionary<string, string>();


        public Dictionary<string, string> mDict = new Dictionary<string, string>();

        public string Grade;

        public void addGrade<Generic_Variable>(Generic_Variable grade) //recieves value to store the field
        {
            Grade = ($"{grade}");
        }

        public string mexicanNote()
        {
            #region Dict Builder
            mDict.Add("10", "A+");
            mDict.Add("9", "A");
            mDict.Add("8", "B");
            mDict.Add("7.9", "C+");
            mDict.Add("7", "C");
            mDict.Add("6", "D");
            mDict.Add("5", "F");
            mDict.Add("A+", "10");
            mDict.Add("A", "9");
            mDict.Add("B", "8");
            mDict.Add("C+", "7.9");
            mDict.Add("C", "7");
            mDict.Add("D", "6");
            mDict.Add("F", "5");

            #endregion

            return mDict[Grade];
        }
        public string americanNote()
        {
            #region Dict Builder
            mDict.Add("10", "A+");
            mDict.Add("9", "A");
            mDict.Add("8", "B");
            mDict.Add("7.9", "C+");
            mDict.Add("7", "C");
            mDict.Add("6", "D");
            mDict.Add("5", "F");
            mDict.Add("A+", "10");
            mDict.Add("A", "9");
            mDict.Add("B", "8");
            mDict.Add("C+", "7.9");
            mDict.Add("C", "7");
            mDict.Add("D", "6");
            mDict.Add("F", "5");
            #endregion

            return (mDict[Grade]);


        }

        public static string getChosenClasses(int i)
        {
            

            Console.WriteLine($"student {(i+1)}please chose from the following options by sellecting the corresponding number \n 1) {Classes.Algebra} \n 2) {Classes.Geography} \n 3) {Classes.English}");

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

        public void setClasses(string classes)
        {
            this.classes = classes;
        }
        
        public string getClasses()
        {
            
            return this.classes;
        }





        public Student(ref int students)
        {
            
            students +=1; // School.students += 1;
            this.id = students;
        }

    }
}
