//MenFromBoys

public static int[] MenFromBoys(int[] a)
{
 return a.Where(x => x % 2 == 0).OrderBy(x => x).Concat(a.Where(x => x % 2 != 0).OrderBy(x => -x)).Distinct().ToArray();
}