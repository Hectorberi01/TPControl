namespace TPControl;

public class YamsGame
{
    public bool IsYams(List<int> roll)
    {
        if (roll.Count != 5) return false;
        
        return roll.Distinct().Count() == 1;
    }
    
    public bool IsGrandeSuite(List<int> roll)
    {
        if (roll.Count != 5) return false;
        roll.Sort();
        return roll.SequenceEqual(new List<int> { 1, 2, 3, 4, 5 }) || 
               roll.SequenceEqual(new List<int> { 2, 3, 4, 5, 6 });
    }
    
    public bool IsFull(List<int> roll)
    {
        if (roll.Count != 5) return false;
        var groups = roll.GroupBy(x => x);
        return groups.Count() == 2 && groups.Any(g => g.Count() == 3);
    }
    
    public bool IsCarre(List<int> roll)
    {
        if (roll.Count != 5) return false;
        return roll.GroupBy(x => x).Any(g => g.Count() == 4);
    }
    
    public bool IsBrelan(List<int> roll)
    {
        if (roll.Count != 5) return false;
        return roll.GroupBy(x => x).Any(g => g.Count() == 3);
    }
    
    public int SumRoll(List<int> roll)
    {
        if (roll.Count != 5) throw new Exception();
        return roll.Sum();
    }
}