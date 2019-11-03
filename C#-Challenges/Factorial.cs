//Factorial

 public static int Factorial(int n)
  {
    if(n < 0 || n > 12)
      throw new ArgumentOutOfRangeException("n must be greater than 0 or less than 13.");    
    return n > 0 ? n * Factorial(n - 1) : 1;
  }