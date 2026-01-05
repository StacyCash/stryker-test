namespace FunctionsLibrary;

using System;
using BaseLibrary;

public static class ComplexFunctions
{
    /// <summary>
    /// Computes n! for non-negative integers using 64-bit arithmetic.
    /// Throws ArgumentException for negative inputs and OverflowException when the result does not fit in Int64.
    /// Uses BaseLibrary.BaseFunctions.Multiply when the current intermediate result fits in Int32 to demonstrate use of the base functions.
    /// </summary>
    public static long Factorial(int n)
    {
        if (n < 0) throw new ArgumentException("Factorial is not defined for negative integers.", nameof(n));
        if (n == 0 || n == 1) return 1;

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            // Check overflow: result * i > long.MaxValue -> overflow
            if (result > long.MaxValue / i)
            {
                throw new OverflowException($"Factorial({n}) would overflow an Int64.");
            }

            // When result fits in Int32 we call the example BaseFunctions.Multiply to show usage of the base library,
            // but only if the int multiplication itself won't overflow.
            if (result <= int.MaxValue && (long)result * i <= int.MaxValue)
            {
                // Both operands fit into int here: safe to cast
                int prod = BaseFunctions.Multiply((int)result, i);
                result = prod; // implicit conversion to long
            }
            else
            {
                result *= i;
            }
        }

        return result;
    }
}
