using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_15Nov
{
    internal class Teacher
    {
        public delegate void emptyEvent();
         private Student _students;
        
        public Teacher(Student students)
        {
            this._students = students;
            onStart = welcome;
            //I have 5 students, 3 will respond no
            startroll = firstStudent;
            goodroll = secondStudent;
            badroll = fourthStudent;
            worseroll = fifthStudent;
            onStart();
        }

        public event emptyEvent onStart;
        public event emptyEvent startroll;
        public event emptyEvent goodroll;
        public event emptyEvent badroll;
        public event emptyEvent worseroll;
        public void welcome()
        {
            Console.WriteLine("Good morning class I am about to start roll call, please take your seats and listen up!");
            startroll();
        }

        public void firstStudent()
        {
            Console.WriteLine($"{_students._students[0]} are you here?");
            Console.WriteLine("No.");
            startroll = firstNo;
            startroll();
        }
        public void secondStudent()
        {
            Console.WriteLine($"{_students._students[1]} are you here?");
            Console.WriteLine("Yes!");
            Console.WriteLine($"Thats wonderful to hear! Thank you {_students._students[1]}!!!!!");
            goodroll = thirdStudent;
            goodroll();
        }
        public void thirdStudent()
        {
            Console.WriteLine($"{_students._students[2]} are you here?");
            Console.WriteLine("Si!");
            Console.WriteLine($"Thats amazing to hear! Thank you {_students._students[2]}!!!!! some people could learn from you");
            
            badroll();
        }
        public void fourthStudent()
        {
            Console.WriteLine($"{_students._students[3]} are you here?");
            Console.WriteLine("No.");
            badroll = secondNo;
            badroll();
        }
        public void fifthStudent()
        {
            Console.WriteLine($"{_students._students[4]} are you here?");
            Console.WriteLine("No.");
            worseroll = thirdNo;
            worseroll();
        }

        public void firstNo()
        {
            Console.WriteLine($"{_students._students[0]} I AM THE TEACHER DO NOT SAY NO TO MEEEE YOUR GRADE IS NOW A 0!!!!!!");
            _students._studentGrades[_students._students[0]] = 0;
            goodroll();
        }

        public void secondNo()
        {
            Console.WriteLine($"{_students._students[3]} You are here I SEE YOU!! You Failed your grade is now a 0!!!!");
            _students._studentGrades[_students._students[3]] = 0;
            worseroll();
        }

        public void thirdNo()
        {
            Console.WriteLine($"{_students._students[4]} REEEEEEEEEEE! YOUR GRADE IS NOW A 0!!!!!!");
            _students._studentGrades[_students._students[4]] = 0;
           
        }

    }
}
