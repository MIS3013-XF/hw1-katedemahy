// HW1b Grade

// Your Name:
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        private const double ASSIGNMENTS_WEIGHT = .20;
        private const double EXAM1_WEIGHT = .15;
        private const double EXAM2_WEIGHT = .25;
        private const double EXAM3_WEIGHT = .25;
        private const double PARTICIPATION_WEIGHT = .15;

        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your student ID number?");
            string studentId = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for assignments?");
            double assignmentGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for Exam 1?");
            double exam1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for Exam 2?");
            double exam2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for Exam 3?");
            double exam3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participation?");
            double participation = Convert.ToDouble(Console.ReadLine());

            double finalGrade = (assignmentGrade * ASSIGNMENTS_WEIGHT) +
                (exam1 * EXAM1_WEIGHT) + (exam2 * EXAM2_WEIGHT) +
                (exam3 * EXAM3_WEIGHT) + (participation * PARTICIPATION_WEIGHT);

            Console.WriteLine();
            Console.WriteLine($"{firstName} {lastName}, {studentId}, Your final grade is {finalGrade}%.");
        }
    }
}
