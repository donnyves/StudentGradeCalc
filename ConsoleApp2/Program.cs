using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int test1, test2, test3, total;
            float avg;
            string StudentName;

          

            Console.WriteLine("Enter Student Name :");
            StudentName = Console.ReadLine();

            Console.WriteLine("Grade for first subject : ");
            test1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Grade for the second subject : ");
            test2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Grade for the third subject : ");
            test3 = Convert.ToInt32(Console.ReadLine());

            total = test1 + test2 + test3;
            avg = total / 3.0f;

            Console.WriteLine($"Hello {StudentName} !");
            Console.WriteLine("Your total is : " + total);
            Console.WriteLine("Your percentage is : " + avg);

            if (avg >= 0 && avg < 59)
            {
                Console.WriteLine("Your grade is an F");
            }
            if (avg >= 60 && avg < 69)
            {
                Console.WriteLine("Your grade is a D");
            }
            if (avg >= 70 && avg <= 79)
            {
                Console.WriteLine("Your grade is a C");
            }
            if (avg > 80 && avg <= 89)
            {
                Console.WriteLine("Your grad is a B");
            }
            if (avg > 90 && avg <= 100)
            {
                Console.WriteLine("Your Grade is an A");
            }
            Console.ReadLine();
        }
    }
}
