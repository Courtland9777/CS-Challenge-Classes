// Ensure all characters are alphanumeric in a string

public static bool Alphanumeric(string str)
{
    if(String.IsNullOrWhiteSpace(str)) return false;
    char[] arr = str.ToCharArray();
    for(int i = 0; i < arr.Length; i++)
    {
        if(!Char.IsLetterOrDigit(arr[i])) return false;
    }
    return true;
}


//Version 2
public static bool Alphanumeric(string str)
  {
    return str.All(c => Char.IsLetterOrDigit(c)) && !string.IsNullOrEmpty(str);
  }