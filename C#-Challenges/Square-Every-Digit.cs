//Square each digit from a given int and join them back together
// 99 would = 8181.

using System;

public class Challenge
{
  public static int SquareDigits(int n)
  {
    string output = "";
    foreach (char c in n.ToString())
    {
      int square = int.Parse(c.ToString());
      output += (square * square);
    }
    return int.Parse(output);
  }
}