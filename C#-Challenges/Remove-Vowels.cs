//Remove Vowels	

public static string Disemvowel(string str)
{
    string vowels = "aeiouAEIOU";
    return new string(str.Where(c => !vowels.Contains(c)).ToArray());
}