using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class Program
    {
        public void GradeCalculator()
        {
            Console.WriteLine("Enter your grade between 0 and 100");
            int grade = int.Parse(Console.ReadLine());

            string gradeLetter;

            if (grade >= 90 && grade <= 100) gradeLetter = "A";
            else if (grade >= 80  && grade <= 89) gradeLetter = "B";
            else if (grade >= 70  && grade <= 79) gradeLetter = "C";
            else if (grade >= 60  && grade <= 69) gradeLetter = "D";
            else if (grade >= 0  && grade <= 59) gradeLetter = "F";
            else{
                Console.WriteLine("Invalid grade entered");
                return;
            }

            Console.WriteLine($"Your grade is " + gradeLetter);
            Console.ReadLine();

        }
    }
}
