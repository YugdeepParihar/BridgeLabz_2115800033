using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        // Number of iterations for concatenation
        int iterations = 100000;

        // Measure time for regular string concatenation
        Stopwatch sw1 = Stopwatch.StartNew();
        string result1 = ConcatenateWithPlusOperator(iterations);
        sw1.Stop();
        Console.WriteLine($"Time taken with '+' operator: {sw1.ElapsedMilliseconds} ms");

        // Measure time for StringBuilder concatenation
        Stopwatch sw2 = Stopwatch.StartNew();
        string result2 = ConcatenateWithStringBuilder(iterations);
        sw2.Stop();
        Console.WriteLine($"Time taken with StringBuilder: {sw2.ElapsedMilliseconds} ms");
    }

    static string ConcatenateWithPlusOperator(int iterations)
    {
        string result = "";

        for (int i = 0; i < iterations; i++)
        {
            result += "a"; // Concatenate using the '+' operator
        }

        return result;
    }

    static string ConcatenateWithStringBuilder(int iterations)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < iterations; i++)
        {
            sb.Append("a"); // Concatenate using StringBuilder
        }

        return sb.ToString();
    }
}