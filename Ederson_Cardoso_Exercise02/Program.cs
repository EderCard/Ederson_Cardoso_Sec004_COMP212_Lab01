using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Define a student’s grade array having at least 10 double values between 10 and 100. Define a delegate –
 * GradesPredicate which takes one input of type double and returns a bool.
 *
 * Define a method – GradesFilter which displays only those grades values which are greater than or equal to 50.
 * This method should take an array of type doubles and second argument is a variable of GradesPredicate.
 * This method should not return any type.
 * We should call this method like this:
 *     GradesFilter(gradesArray, lambda-Expression);
 * 
 * Lambda-Expression should filter values which are greater than or equal to 50.
 */
namespace Ederson_Cardoso_Exercise02
{
    // Delegate for a function that receives a double and returns a bool
    public delegate bool GradesPredicate(double grade);
    class Program
    {
        static void Main(string[] args)
        {
            double[] gradesArray = { 40, 45, 30, 80, 85, 70, 60, 75, 90, 50 };

            // Filter grades greater than or equal to 50 using an implicit lambda statement
            GradesFilter(gradesArray, grade => { return grade >= 50; });
        } // end Main
        
        /// <summary>
        /// This method returns grades based on gradesArray and a delegate funtion predicate
        /// </summary>
        /// <param name="gradesArray"></param>
        /// <param name="predicate"></param>
        private static void GradesFilter(double[] gradesArray, GradesPredicate predicate)
        {
            // Iterate over each element in the array
            foreach (double item in gradesArray)
            {
                // Print elements that satisfies the predicate
                if (predicate(item))
                {
                    Console.Write($"{item} "); // print item followed by a space
                }
            }
            Console.WriteLine();
        } // end method GradesFilter

    } //end class
} // end namespace
