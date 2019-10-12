//You always walk only a single block in a direction and you know it takes you one minute to traverse one city block, 
//so create a function that will return true if the walk the app gives you will take you exactly ten minutes 
//(you don't want to be early or late!) and will, of course, return you to your starting point. Return false otherwise.


public class Challenge
{
  public static bool IsValidWalk(string[] walk)
    {
        if(walk.Length != 10)
        {
            return false;
        }
        int nsCounter = 0;
        int ewCounter = 0;
        
        for(int i = 0; i < walk.Length; i++)
        {
            switch(walk[i])
            {
                case "n":
                    nsCounter++;
                    break;
                case "s":
                    nsCounter--;
                    break;
                case "e":
                    ewCounter++;
                    break;
                case "w":
                    ewCounter--;
                    break;            
            }
        }
        if(ewCounter == 0 && nsCounter == 0)
        {
            return true;
        }
        return false;
    }
}