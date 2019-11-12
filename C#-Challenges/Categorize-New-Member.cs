//Categorize New Member


public static IEnumerable<string> OpenOrSenior(int[][] data)
{
    var list = new List<string>();
    for (int i = 0; i < data.Length; i++)
    {
        if(data[i][0] > 54 && data[i][1] > 7) list.Add("Senior");
        else list.Add("Open");
    }
    return list;
}


//Using Linq
public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        return data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open").ToList();
    }