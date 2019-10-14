//Count "good" and "bad" ideas in an array and return the correct response.

public class Kata
{
  public static string Well(string[] x)
  {   
      int gIdea = 0, bIdea = 0;
      for(int i = 0; i < x.Length; i++)
      {
          if(x[i].Equals("good")) gIdea++;
          else bIdea++;
      }
      if(gIdea > 2) return "I smell a series!";
      else if(gIdea == 1 || gIdea == 2) return "Publish!";
      else return "Fail!";
    }  
}

// Linq version

using System.Linq;

public class Kata
{
  public static string Well(string[] x)
  {
    int count = x.Count(v => v == "good");
    return (count > 2) ? "I smell a series!" : (count >= 1) ? "Publish!" : "Fail!";
  }
}