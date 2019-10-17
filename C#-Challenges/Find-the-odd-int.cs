// Find the int that appears an odd number of time in the array.



class Challenge
{
	public static int find_it(int[] seq)
	{

	int res = 0; 
	for (int i = 0; i < seq.Length; i++)  
	{ 
		res ^= seq[i]; 
	} 
	return res; 
	}
}


class Challenge
{
	  public static int find_it(int[] seq) 
	  {
		return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
	  }
}