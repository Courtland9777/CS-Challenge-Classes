//Reverse the content of a string.


public static class Challenge 
{
	public static string Reverse( string s )
	{
		char[] charArray = s.ToCharArray();
		Array.Reverse( charArray );
		return new string( charArray );
	}
}