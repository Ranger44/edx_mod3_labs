/*The sum functions are an example of overloading.
 * The division function is an example of exception handling.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = Sum(20, 40);
            //Console.WriteLine($"Calling Sum() with two arguments, result is: {result}");

            //int result3 = Sum(10, 50, 80);
            //Console.WriteLine($"Calling Sum() with three arguments, result is: {result3}");

            //double dblResult = Sum(20.5, 30.6);
            //Console.WriteLine($"Calling Sum() that takes doubles result in: {dblResult}");

            //int result = Divide(2, 0);  

            int first = 9;
            int second = 0;
            Console.WriteLine("Enter your first number: ");
            first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            second = System.Int32.Parse(Console.ReadLine());

            int result = Divide(first, second);
            Console.WriteLine($"The result of dividing {first} by {second} is {result}");


        }

        // Sum() method that takes two integer arguments and sums them
        // The method returns no value which is why we use void
        // We also need to use static in the method signature because Main is static
        // and you cannot call a non-static method from a static method
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        // Sum() method that takes three integer arguments and sums them
        // and then returns the value
        // This method uses the same name as the Sum() method that takes two integers
        // but the parameters here indicate the method is expecting three integers as arguments
        // The compiler knows which method to call based on the number of arguments passed in
        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }

        // Sum() method that takes two doubles as arguments
        // This method uses the same name as the Sum() method that takes two integers
        // but the parameters here indicate the method is expecting two doubles as arguments
        // The compiler knows which method to call based on the arguments data types
        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }

        // Method Divide() accepts two integer arguments and returns the result
        // of dividing first by second
        // We do no validation of the the arguments so a user may pass in a zero
        // in place of the second parameter.   This is an illegal operation in math
        // If we don't validate input or catch the error, the application will crash
        static int Divide(int first, int second)
        {
            //int result = first / second;  //this needs wrapped in exception handling block
            //return result;

            // Method Divide() that contains exception handling to deal with 
            // divide by zero exceptions.
      
            int result = 0;
            try
            {
                result = first / second;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value");
            }

            return result;
           
        }
    }
}
