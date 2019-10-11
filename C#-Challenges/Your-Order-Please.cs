// Sort a string of words that have a number in the middle by numeric value. Test: Order("is2 Thi1s T4est 3a")

using System;
using System.Linq;

public static class Challenge
{
  public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words)) return words;
            return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
        }
}