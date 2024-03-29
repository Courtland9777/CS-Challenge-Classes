//Create all permutations of an input string and remove duplicates, if present.

using System.Linq;
using System.Collections.Generic;

public static class Challenge
{
    public static List<string> SinglePermutations(string s)
    {   
        List<string> permList = new List<string>();
        foreach(var p in FindPermutations(s))
        {
            permList.Add(p);
        }
        permList = permList.Distinct().ToList();
        
        return permList;
    }

    private static IEnumerable<string> FindPermutations(string set)
    {
        var output = new List<string>();
        switch (set.Length)
        {
            case 1:
                output.Add(set);
                break;
            default:
                output.AddRange(from c in set let tail = set.Remove(set.IndexOf(c), 1) from tailPerms in FindPermutations(tail) select c + tailPerms);
                break;
        }
        return output;
    }
}