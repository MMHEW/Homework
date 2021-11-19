using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Please enter how many Students there are in school: ");
            //int studentNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter how many Teachers there are in school: ");
            //int teacherNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter how many Janitors there are in school: ");
            //int janitorNum = Convert.ToInt32(Console.ReadLine());

            //string[] chosenClass = new string[studentNum];
            //string[] specialClass = new string[teacherNum];

            //for (int i = 0; i < studentNum; i++)
            //{
            //    Student student = new Student(ref School.students);
            //}
            //for (int i = 0; i < teacherNum; i++)
            //{
            //    Teacher teacher = new Teacher(ref School.employees, ref School.teachers);
            //}
            //for (int i = 0; i < janitorNum; i++)
            //{
            //    Janitor janitor = new Janitor(ref School.employees, ref School.janitors);
            //}

            //Console.WriteLine("\n\nIn this school there is a total of {0} students \n\nThere is a total of {1} employees \n\n\t{2} of those employees are teachers\n\t{3} of those employees are " +
            //    "janitors. ", School.getStudents(), School.getEmployees(), School.getTeachers(), School.getJanitors());

            //Console.WriteLine("\namount of classes we offer is {0} \n", School.getClasses());
            //bool flag;
            //for (int i = 0; i < studentNum; i++)
            //{
            //    do
            //    {
            //        try
            //        {
            //            chosenClass[i] = Student.getChosenClasses(i);

            //            flag = true;
            //        }
            //        catch (Exception e)
            //        {
            //            flag = false;
            //        }
            //    }
            //    while (!flag);
            //}

            //for (int i = 0; i < teacherNum; i++)
            //{
            //    do
            //    {
            //        try
            //        {
            //            specialClass[i] = Teacher.getChosenClasses(i);
            //            flag = true;
            //        }
            //        catch (Exception e)
            //        {
            //            flag = false;
            //        }
            //    }
            //    while (!flag);
            //}

            //Console.Clear();

            //for (int i = 0; i < chosenClass.Length; i++)
            //{
            //    Console.WriteLine($"Student {(i + 1)} has chosen to enroll in {chosenClass[i]}");
            //}

            //for (int i = 0; i < specialClass.Length; i++)
            //{
            //    Console.WriteLine($"teacher {(i + 1)} teaches {specialClass[i]}");
            //}

            //for (int i = 0; i < studentNum; i++)
            //{
            //    string classes = Student.getRandomClasses();
            //    Console.WriteLine($"Student {(i+1)} is enrolled in {classes}");
            //}

            //Console.WriteLine();

            //for (int i = 0; i < teacherNum; i++)
            //{
            //    string classes = Teacher.getRandomClasses();
            //    Console.WriteLine($"Teacher {(i + 1)} instructs {classes}");
            //}
            Student student1 = new Student(ref School.students);
            student1.addGrade(5);

            Console.WriteLine($"{student1.mexicanNote()} is the american notation of {student1.Grade}");
            Student student2 = new Student(ref School.students);

            student2.addGrade("A+");
            Console.WriteLine($"{student2.americanNote()} is the mexican notation of {student2.Grade}");
            //Student student3 = new Student(ref School.students);
            //Student student4 = new Student(ref School.students);
            //Teacher teacher1 = new Teacher(ref School.employees, ref School.teachers);
            //Teacher teacher2 = new Teacher(ref School.employees, ref School.teachers);
            //Teacher teacher3 = new Teacher(ref School.employees, ref School.teachers);
            //Teacher teacher4 = new Teacher(ref School.employees, ref School.teachers);
            //Janitor janitor1 = new Janitor(ref School.employees, ref School.janitors);
            //Janitor janitor2 = new Janitor(ref School.employees, ref School.janitors);
            //Janitor janitor3 = new Janitor(ref School.employees, ref School.janitors);
            //Janitor janitor4 = new Janitor(ref School.employees, ref School.janitors);
            //Janitor janitor5 = new Janitor(ref School.employees, ref School.janitors);


            //Console.WriteLine("\n\nIn this school there is a total of {0} students \n\nThere is a total of {1} employees \n\n\t{2} of those employees are teachers\n\t{3} of those employees are " +
            //    "janitors. ", School.getStudents(), School.getEmployees(), School.getTeachers(), School.getJanitors());

            //Console.WriteLine("\namount of classes we offer is {0}", School.getClasses());

            //student1.setClasses($"{Classes.English}");
            //Console.WriteLine("\nstudent 1 has {0} class.", student1.getClasses());
            //student2.setClasses($"{Classes.Algebra}");
            //Console.WriteLine("\nstudent 2 has {0} class.", student1.getClasses());
            //student3.setClasses($"{Classes.Geography}");
            //Console.WriteLine("\nstudent 3 has {0} class.", student1.getClasses());
            //student4.setClasses($"{Classes.English}");
            //Console.WriteLine("\nstudent 4 has {0} class.", student1.getClasses());

            //teacher1.setClasses($"{Classes.English}");
            //Console.WriteLine("\nteacher 1 has {0} class.", teacher1.getClasses());
            //teacher2.setClasses($"{Classes.Algebra}");
            //Console.WriteLine("\nteacher 2 has {0} class.", teacher2.getClasses());
            //teacher3.setClasses($"{Classes.Geography}");
            //Console.WriteLine("\nteacher 3 has {0} class.", teacher3.getClasses());
            //teacher4.setClasses($"{Classes.English}");
            //Console.WriteLine("\nteacher 4 has {0} class.", teacher4.getClasses());

            Console.WriteLine("\n\n\n\nPlease press any key to exit the program.");
            Console.ReadKey();
        }
    }
}
