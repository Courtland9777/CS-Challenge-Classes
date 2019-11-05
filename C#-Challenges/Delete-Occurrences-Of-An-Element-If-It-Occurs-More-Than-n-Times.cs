//Delete occurrences of an element if it occurs more than n times

public static int[] DeleteNth(int[] arr, int x) {
	var result = new List<int>();
	foreach(var item in arr) {
	  if(result.Count(i => i == item) < x)
		result.Add(item);
	}
	return result.ToArray();
}