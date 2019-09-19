using System;

namespace ISM4331_Week4_InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            // This variable will gather the user input
            string name = Console.ReadLine();

            Console.WriteLine("Please, put your age");
            int age = int.Parse(Console.ReadLine());

            int grade = int.Parse(Console.ReadLine());
            try
            {
                
                // Here's the grading criteria according to the syllabus
                if (grade > 89 && grade < 101)
            {
                Console.WriteLine("You are going to get an A");
            }
           
            if (grade > 79 && grade < 90)
            {
                Console.WriteLine("You are going to get an B");
            }
            else if (grade > 69 && grade < 80)
            {
                Console.WriteLine("You are going to get an C");
            }
            
            else if (grade > 59 && grade < 70)
            {
                Console.WriteLine("You are going to get an D");
            }
           

            else if (grade < 60 && grade > 0)
            {
                Console.WriteLine("You are going to get an F");
            }

            else 
                {
                    Console.WriteLine("Please, put a valid number");
                }

        }
            catch
            {
                Console.WriteLine("your name is " + name + "your age" + age);
                Console.WriteLine("Your grades are:");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }

        }
    }
}
