//Find the next perfect square!


public static long FindNextSquare(long num)
{
	double result = Math.Sqrt(num);
	if(result % 1 != 0) return -1;
	long nextN = (long)Math.Floor(Math.Sqrt(num)) + 1; 

	return nextN * nextN; 
}