//Convert number to reversed array of digits

public static long[] Digitize(long n)
{
    return n.ToString().Reverse().Select(digit => long.Parse(digit.ToString())).ToArray();   
}