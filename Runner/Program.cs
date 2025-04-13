using System;
using DSA.Arrays;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running TwoSum...");
        int[] result = TwoSumSolution.TwoSum(new[] { 2, 7, 11, 15 }, 9);
        Console.WriteLine($"Result: [{string.Join(", ", result)}]");
    }
}