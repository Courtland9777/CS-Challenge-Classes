//Create a Pyramid array. Array size continues to grow with each iteration. 

//for
public static int[][] Pyramid(int n) 
{
    if(n == 0) return new int[0][];
    int[][] arr = new int[n][];
    
        for(int i = 0; i < n; i++)
        {
            arr[i] = new int[i + 1];
            for(int j = 0; j <= i; j++)
            {
                arr[i][j] = 1;
            
            }
        }       
    return arr;
}


//Linq
public static int[][] Pyramid(int n) {
    return Enumerable.Range(1, n).Select(i => Enumerable.Repeat(1, i).ToArray()).ToArray();
}