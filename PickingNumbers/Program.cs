using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{

    public static int pickingNumbers(List<int> a)
    {
        int[] freq = new int[100];

        foreach (int num in a)
        {
            freq[num]++;
        }

        int maxLength = 0;

        for (int i = 0; i < 99; i++)
        {
            maxLength = Math.Max(maxLength, freq[i] + freq[i + 1]);
        }

        return maxLength;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
