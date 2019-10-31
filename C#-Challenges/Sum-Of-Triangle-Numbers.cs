//Sum of triangle numbers

public static int SumTriangularNumbers(int n)
{
    if(n<0) return 0;
    int j = 1, k = 1, tSum = 0; 
    for (int i = 1; i <= n; i++) 
    { 
        tSum += k;
        j += 1;  
        k += j; 
    } 
    return tSum;
}