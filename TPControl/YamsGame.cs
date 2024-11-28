namespace TPControl;

public class YamsGame
{
    public bool IsYams(List<int> roll)
    {
        if (roll.Count != 5) return false;
        
        return roll.Distinct().Count() == 1;
    }
}