//Sum of Intervals


public class Interval
{
    public int start;
    public int end;
    
    public Interval(int s, int e) 
    { 
        start = s; 
        end = e; 
    }
}

public static int SumIntervals((int, int)[] intervals)
{
    List<Interval> intList = new List<Interval>();
    for(int i = 0; i < intervals.Length; i++)
    {
       intList.Add(new Interval(intervals[i].Item1,intervals[i].Item2));   
    }
    IList<Interval> mergedList = Merge(intList);
    
    int total = 0;
    foreach (var element in mergedList)
    {
        total += (element.end - element.start);
    }
     
    return total;
}
    
public static IList<Interval> Merge(IList<Interval> intervals)
{
    var res = new List<Interval>();
    intervals = intervals.OrderBy(x => x.start).ToList();
    for (int i = 0; i < intervals.Count; i++)
    {
        var newInterval = new Interval(intervals[i].start, intervals[i].end);
        while (i < intervals.Count - 1 && newInterval.end >= intervals[i + 1].start)
        {
            newInterval.end = Math.Max(newInterval.end, intervals[i + 1].end);
            i++;
        }
        res.Add(newInterval);
    }
    return res;
}


//Variation 2


public class Intervals
{
  public static int SumIntervals((int, int)[] intervals)
  {
    return intervals
      .SelectMany(i => Enumerable.Range(i.Item1, i.Item2 - i.Item1))
      .Distinct()
      .Count();
  }
}


