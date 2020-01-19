using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ederson_Cardoso_Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1a - Func<> delegate predicate
            // Read input strings
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            Console.Write("Enter third string: ");
            string str3 = Console.ReadLine();

            // Func delegate using lambda and the method Minimum
            Func<string, string, string, string> smallest = (string string1, string string2, string string3) => Minimum(str1, str2, str3);
           
            // Calling delegate
            string str = smallest(str1, str2, str3);
            Console.WriteLine("The smallest string is: " + str);
           
            Console.WriteLine("\n-----------------------------");
            
            // Exercise 1b - Action<> delegate predicate
            // Read input strings
            Console.Write("Enter first grade: ");
            double g1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second grade: ");
            double g2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter third grade: ");
            double g3 = Convert.ToDouble(Console.ReadLine());

            // Action delegate using lambda and the method AvgGrade
            Action<double, double, double> average = (double grade1, double grade2, double grade3) => AvgGrade(g1, g2, g3);
            average(g1, g2, g3);
        }

        /// <summary>
        /// This method returns the smallest of three strings
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        /// <param name="string3"></param>
        /// <returns></returns>
        private static string Minimum(string string1, string string2, string string3)
        {
            string smallestString = string1;

            if (string2.Length < smallestString.Length)
            {
                smallestString = string2;
            }
            if (string3.Length < smallestString.Length)
            {
                smallestString = string3;
            }
            return smallestString;
        }

        /// <summary>
        /// This method returns the average of three doubles
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        public static void AvgGrade(double value1, double value2, double value3)
        {
            double result = (value1 + value2 + value3) / 3;
            Console.WriteLine("The average is: " + result);
        }

    } // end class
} // end namespace
