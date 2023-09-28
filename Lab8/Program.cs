using System;
using System.Text.RegularExpressions;

namespace Lab8
{
    public static class ExtentionString
    {
        public static int CountOccurrences(this string str, string pattern)
        {
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(str);
            return matches.Count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "This is an example, and this is another example.";
            string pattern = "example";
            int count = input.CountOccurrences(pattern);
            Console.WriteLine($"Number of occurrences of '{pattern}': {count}");
        }
    }
}
