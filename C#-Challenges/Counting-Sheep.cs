//Counting sheep

public static int CountSheeps(bool[] sheeps)
{
	return sheeps.Where(s => s == true).Count();
}