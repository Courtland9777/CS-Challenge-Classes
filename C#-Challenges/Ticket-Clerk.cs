//Check if cashier can provide change to all customers in line w/o having any cash on hand to begin with.
//Only denominations accepted are $25, $50 and $100 and tickets are $25 a piece.

public static class Challenge 
{
	public static string Tickets(int[] peopleInLine)
	{ 
		
		if (peopleInLine[0] != 25) { return "NO"; }
		int twentyfive = 1;
		int fifty = 0;
		for (int i = 1; i < peopleInLine.Length; i++)
		{
			if (peopleInLine[i] == 25)
			{
				twentyfive += 1;
			}
			else if (peopleInLine[i] == 50 && twentyfive > 0) 
			{
				twentyfive -= 1;
				fifty += 1;
			}
			else if (peopleInLine[i] == 100 && twentyfive > 2) 
			{
				twentyfive -= 3;
			}
			else if (peopleInLine[i] == 100 && twentyfive > 0 && fifty > 0) 
			{
				twentyfive -= 1;
				fifty -= 1;
			}
			else
			{return "NO";}
		}
		return "YES";
	}
}    