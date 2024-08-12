using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_205_HW5_3
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number".

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                case "e":
                    // Exponentiation: num1 raised to the power of num2
                    result = Math.Pow(num1, num2);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }
}


// 2. When I try to divide a number by zero, its gives me this response
// This operation will result in a mathematical error.
// If I try to input something thats not a number it will just prompt me again to
// input a actual number


// 4. It's generally a good practice to keep UI and error-handling separate
// from business logic (like calculations). This separation allows each
// class to focus on a single responsibility, making the code easier to
// understand, test, and maintain. The current setup, where the Program
// class handles UI and error-catching, while the Calculator class focuses
// on computation, follows this principle well. Therefore, it is advisable
// to keep the current structure as is.