//Get vowel count from string

public static int GetVowelCount(string str)
{
	var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
	return str.Count(c => vowels.Contains(c));;
}