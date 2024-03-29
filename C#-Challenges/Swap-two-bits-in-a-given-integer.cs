// C# program to swap bits in an intger 
using System; 
  
public static class Challenge 
{ 
	static int swapBits(int n, int p1, int p2) 
	{ 
		int bit1 = (n >> p1) & 1; 
		int bit2 = (n >> p2) & 1; 
	  
		int x = (bit1 ^ bit2); 
	  
		x = (x << p1) | (x << p2); 
	  
		int result = n ^ x; 
		return result; 
	} 
} 