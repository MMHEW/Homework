using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                
                Console.WriteLine("Please choose an option");
                Console.WriteLine("#1 Calculate monthly salary");
                Console.WriteLine("#2 Compare your grade to minimum passing grade");
                Console.WriteLine("#3 Multiply two numbers");
                Console.WriteLine("#4 Divide two numbers");
                Console.WriteLine("#5 Calculate wich of two numbers is bigger");
                Console.WriteLine("#6 Calculate if a number is even or odd");
                Console.WriteLine("#7 exit the program");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        bool flag2 = false;
                        do
                        {
                            Console.WriteLine("Please select option 1 if the employee is salaried and option 2 if employee is hourly");
                            int option1 = Convert.ToInt32(Console.ReadLine());
                        
                        
                            if (option1 == 1)
                            {
                                Console.WriteLine("What is the yearly salary for the employee?");
                                decimal salary = Convert.ToDecimal(Console.ReadLine());
                                salary = salary / 12;
                                Console.WriteLine("the monthly salary is " + salary);
                                flag2 = false;
                            }

                            else if (option1 == 2)
                            {

                                Console.WriteLine("How many hours did the employee work?");
                                decimal hours = Convert.ToDecimal(Console.ReadLine());
                                Console.WriteLine("How much does this employee make per hour?");
                                decimal Wage = Convert.ToDecimal(Console.ReadLine());
                                decimal monthlySalary = Wage * hours;
                                Console.WriteLine("This employee make {0} per month", monthlySalary);
                                flag2 = false;
                            }
                            else
                            {
                                Console.WriteLine("please enter a valid option");
                                flag2 = true;

                            }
                        }
                        while (flag2);
                        
                        break;

                    case 2:
                        Console.WriteLine("what is your grade?");
                        int grade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the minimum needed to pass?");
                        int minimum = Convert.ToInt32(Console.ReadLine());

                        if(grade >= minimum)
                        {
                            Console.WriteLine("Congratulations you passed!");
                        }
                        else
                        {
                            Console.WriteLine("Im sorry you failed");
                        }
                        break;

                    case 3:
                        Console.WriteLine("what is the first number?");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the second number?");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        if (num1 == 0 || num2 ==0)
                        {
                            Console.WriteLine("a number multiplied by 0 will always be 0");
                        }
                        else
                        {
                            int mResult = num1 * num2;
                            Console.WriteLine("The solution is " + mResult);
                        }
                        break;

                    case 4:
                        Console.WriteLine("what is the first number?");
                        int dnum1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the second number?");
                        int dnum2 = Convert.ToInt32(Console.ReadLine());

                        if (dnum1 == 0 || dnum2 == 0)
                        {
                            Console.WriteLine("you may not divide by 0");
                        }
                        else
                        {
                            int dResult = dnum1 / dnum2;
                            Console.WriteLine("The solution is " + dResult);
                        }
                        break;

                    case 5:
                        Console.WriteLine("what is the first number?");
                        int cnum1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the second number?");
                        int cnum2 = Convert.ToInt32(Console.ReadLine());

                        if (cnum1 > cnum2)
                        {
                            Console.WriteLine(cnum1 + " Is the bigger number");
                        }
                        else
                        {
                            Console.WriteLine(cnum2 + " is the bigger number");
                        }
                        break;

                    case 6:
                        Console.WriteLine("what is the number you want to see is even or odd?");
                        int modulous = Convert.ToInt32(Console.ReadLine());
                        modulous = modulous % 2;

                        if(modulous != 0)
                        {
                            Console.WriteLine(modulous + " is an odd number");
                        }
                        else
                        {
                            Console.WriteLine(modulous + " is an even number");
                        }
                        break;

                    case 7:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("there is no such program");
                        break;

                }
            }

            while (flag);

        }
    }
}
