namespace TPControl;

public class YamsGame
{
    private HashSet<string> usedFigures = new HashSet<string>();

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
    
    
    public int AnalyzeRoll(List<int> roll)
    {
        if (IsYams(roll)) return 50;
        if (IsGrandeSuite(roll)) return 40;
        if (IsFull(roll)) return 30;
        if (IsCarre(roll)) return 35;
        if (IsBrelan(roll)) return 28;

        return SumRoll(roll); 
    }
    
    public (string, int) AnalyzeRollWithFigure(List<int> roll)
    {
        if (IsYams(roll) && !usedFigures.Contains("Yams"))
        {
            usedFigures.Add("Yams");
            return ("Yams", 50);
        }

        if (IsGrandeSuite(roll) && !usedFigures.Contains("GrandeSuite"))
        {
            usedFigures.Add("GrandeSuite");
            return ("GrandeSuite", 40);
        }

        if (IsFull(roll) && !usedFigures.Contains("Full"))
        {
            usedFigures.Add("Full");
            return ("Full", 30);
        }

        if (IsCarre(roll) && !usedFigures.Contains("Carre"))
        {
            usedFigures.Add("Carre");
            return ("Carre", 35);
        }

        if (IsBrelan(roll) && !usedFigures.Contains("Brelan"))
        {
            usedFigures.Add("Brelan");
            return ("Brelan", 28);
        }

        return ("Chance", SumRoll(roll));
    }

    public List<(string Figure, int Points)> ProcessRolls(List<List<int>> rolls)
    {
        usedFigures.Clear();
        var results = new List<(string Figure, int Points)>();

        foreach (var roll in rolls)
        {
            var result = AnalyzeRollWithFigure(roll);
            results.Add(result);
        }

        return results;
    }
}