//add two int and convert them into a binary string

using System;

public static class Challenge
{
  public static string AddBinary(int a, int b) =>
    Convert.ToString(a + b, 2);
}