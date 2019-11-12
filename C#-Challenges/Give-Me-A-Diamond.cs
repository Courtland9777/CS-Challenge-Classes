//Give me a Diamond

public static string print(int n)
{
  if (n%2 == 0 || n<0)
  {
	  return null;
  }

  int middle = n/2;
  StringBuilder sb = new StringBuilder();
  for (int index = 0; index < n; index++)
  {
	  sb.Append(' ', Math.Abs(middle - index));
	  sb.Append('*', n - Math.Abs(middle - index) * 2);
	  sb.Append("\n");
  }

  return sb.ToString();
}