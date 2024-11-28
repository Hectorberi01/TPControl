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
}