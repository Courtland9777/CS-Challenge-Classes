//Shortest word in String


public static int FindShort(string s)
{
return s.Split(' ').Min(x => x.Length);
}