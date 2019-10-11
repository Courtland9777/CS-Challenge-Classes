//Write Number in Expanded Form

using System;
using System.Linq;

public static class Challenge 
{
    public static string ExpandedForm(long num) 
    {
            var str = num.ToString();
            return String.Join(" + ", str
                .Select((x, i) => char.GetNumericValue(x) * Math.Pow(10, str.Length - i - 1))
                .Where(x => x > 0));
    }
}