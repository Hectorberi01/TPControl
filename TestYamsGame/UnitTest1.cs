using TPControl;

namespace TestYamsGame;

public class UnitTest1
{
    [Fact]
    public void TestIsYams()
    {
        List<int> yamsList = new List<int> { 6, 6, 6, 6, 6 };
        List<int> yamsList2 = new List<int> { 6, 6, 6, 6, 5 };
        List<int> yamsList3 = new List<int> { 2, 3, 4, 5, 6,7};
        var game = new YamsGame();

        Assert.True(game.IsYams(yamsList));
        Assert.False(game.IsYams(yamsList2));
        Assert.False(game.IsYams(yamsList3));
    }

    [Fact]
    public void TestIsGrandeSuite()
    {
        List<int> yamsList = new List<int> { 1, 2, 3, 4, 5 };
        List<int> yamsList2 = new List<int> { 6, 6, 6, 6, 5};
        List<int> yamsList3 = new List<int> { 2, 3, 4, 5, 6};
        List<int> yamsList4 = new List<int> { 2, 3, 4, 5, 6,7};
        
        var game = new YamsGame();
        
        Assert.True(game.IsGrandeSuite(yamsList));
        Assert.False(game.IsGrandeSuite(yamsList2));
        Assert.True(game.IsGrandeSuite(yamsList3));
        Assert.False(game.IsGrandeSuite(yamsList4));
        
    }
    
    [Fact]
    public void TestIsFull()
    {
        List<int> yamsList = new List<int> { 1, 2, 3, 4, 5 };
        List<int> yamsList2 = new List<int> { 6, 6, 6, 6, 5};
        List<int> yamsList3 = new List<int> { 2, 2, 4, 4, 3};
        List<int> yamsList4 = new List<int> { 2, 2, 4, 4, 4};
        List<int> yamsList5 = new List<int> { 2, 3, 2, 5, 5,5};
        
        var game = new YamsGame();
        Assert.False(game.IsFull(yamsList));
        Assert.False(game.IsFull(yamsList2));
        Assert.False(game.IsFull(yamsList3));
        Assert.True(game.IsFull(yamsList4));
        Assert.False(game.IsFull(yamsList5));
    }

    [Fact]
    public void TestIsCarre()
    {
        List<int> yamsList = new List<int> { 1, 2, 3, 4, 5 };
        List<int> yamsList2 = new List<int> { 6, 6, 6, 6, 5};
        List<int> yamsList3 = new List<int> { 2, 2, 4, 4, 3};
        List<int> yamsList4 = new List<int> { 2, 4, 4, 4, 4};
        List<int> yamsList5 = new List<int> { 2, 3, 2, 5, 5,5};
        
        var game = new YamsGame();
        Assert.False(game.IsCarre(yamsList));
        Assert.True(game.IsCarre(yamsList2));
        Assert.False(game.IsCarre(yamsList3));
        Assert.True(game.IsCarre(yamsList4));
        Assert.False(game.IsCarre(yamsList5));
    }

    [Fact]
    public void TestIsBrelan()
    {
        List<int> yamsList = new List<int> { 1, 2, 3, 4, 5 };
        List<int> yamsList2 = new List<int> { 6, 6, 6, 1, 5};
        List<int> yamsList3 = new List<int> { 2, 2, 4, 4, 4};
        List<int> yamsList4 = new List<int> { 2, 4, 4, 4, 4};
        List<int> yamsList5 = new List<int> { 2, 3, 2, 5, 5,5};
        
        var game = new YamsGame();
        
        Assert.False(game.IsBrelan(yamsList));
        Assert.True(game.IsBrelan(yamsList2));
        Assert.True(game.IsBrelan(yamsList3));
        Assert.False(game.IsBrelan(yamsList4));
        Assert.False(game.IsBrelan(yamsList5));
    }

    [Fact]
    public void TestSumRoll()
    {
        List<int> yamsList = new List<int> { 1, 2, 3, 4, 5 };
        List<int> yamsList2 = new List<int> { 6, 6, 6, 1, 5};
        List<int> yamsList3 = new List<int> { 2, 2, 4, 4, 4};
        List<int> yamsList4 = new List<int> { 2, 4, 4, 4, 4};
        List<int> yamsList5 = new List<int> { 2, 3, 2, 5, 5,5};
        
        var game = new YamsGame();
        
        Assert.Equal(15, game.SumRoll(yamsList));
        Assert.Equal(24, game.SumRoll(yamsList2));
        Assert.Equal(16, game.SumRoll(yamsList3));
        Assert.Equal(18, game.SumRoll(yamsList4));
        Assert.Throws<Exception>(() => game.SumRoll(yamsList5));
        
    }

    [Fact]
    public void AnalyzeRoll_WhenYams_ShouldReturn50()
    {
        var game = new YamsGame();
        var roll = new List<int> { 6, 6, 6, 6, 6 }; 

        var result = game.AnalyzeRoll(roll);

        Assert.Equal(50, result);
    }

    [Fact]
    public void AnalyzeRoll_WhenGrandeSuite_ShouldReturn40()
    {
        var game = new YamsGame();
        var roll = new List<int> { 1, 2, 3, 4, 5 }; 

        var result = game.AnalyzeRoll(roll);

        Assert.Equal(40, result);
    }

    [Fact]
    public void AnalyzeRoll_WhenFull_ShouldReturn30()
    {
        var game = new YamsGame();
        var roll = new List<int> { 3, 3, 3, 5, 5 }; 

        var result = game.AnalyzeRoll(roll);

        Assert.Equal(30, result); 
    }
    
    [Fact]
    public void AnalyzeRoll_WhenCarre_ShouldReturn35()
    {
        var game = new YamsGame();
        var roll = new List<int> { 4, 4, 4, 4, 2 };
        var result = game.AnalyzeRoll(roll);
        Assert.Equal(35, result);
    }

    [Fact]
    public void AnalyzeRoll_WhenBrelan_ShouldReturn28()
    {
        var game = new YamsGame();
        var roll = new List<int> { 5, 5, 5, 2, 3 };
        var result = game.AnalyzeRoll(roll);
        Assert.Equal(28, result);
    }

    [Fact]
    public void AnalyzeRoll_WhenNoFigure_ShouldReturnSumOfRoll()
    {
        var game = new YamsGame();
        var roll = new List<int> { 1, 2, 3, 4, 6 };

        var result = game.AnalyzeRoll(roll);

        Assert.Equal(16, result);
    }
    
    
    [Fact]
    public void AnalyzeRollWithFigure_WhenYams_ShouldReturnYamsAnd50Points()
    {
        var game = new YamsGame();
        var roll = new List<int> { 6, 6, 6, 6, 6 };
        var result = game.AnalyzeRollWithFigure(roll);
        Assert.Equal("Yams", result.Item1); 
        Assert.Equal(50, result.Item2); 
    }

    [Fact]
    public void AnalyzeRollWithFigure_WhenFull_ShouldReturnFullAnd30Points()
    {
        var game = new YamsGame();
        var roll = new List<int> { 3, 3, 3, 5, 5 };

        var result = game.AnalyzeRollWithFigure(roll);
        Assert.Equal("Full", result.Item1); 
        Assert.Equal(30, result.Item2); 
    }

    [Fact]
    public void AnalyzeRollWithFigure_WhenNoFigure_ShouldReturnChanceAndSum()
    {
       
        var game = new YamsGame();
        var roll = new List<int> { 1, 2, 3, 4, 6 }; 
        var result = game.AnalyzeRollWithFigure(roll);
        Assert.Equal("Chance", result.Item1);
        Assert.Equal(16, result.Item2);
    }
    
    
    [Fact]
    public void ProcessRolls_ShouldRespectUniqueFigureConstraint()
    {
        var game = new YamsGame();
        var rolls = new List<List<int>>
        {
            new List<int> { 1, 1, 1, 2, 2 },
            new List<int> { 1, 1, 1, 2, 2 },
            new List<int> { 1, 1, 1, 2, 2 }
        };

        var results = game.ProcessRolls(rolls);
        Assert.Equal("Full", results[0].Figure);
        Assert.Equal(30, results[0].Points);

        Assert.Equal("Brelan", results[1].Figure);
        Assert.Equal(28, results[1].Points);

        Assert.Equal("Chance", results[2].Figure);
        Assert.Equal(7, results[2].Points);
    }

    [Fact]
    public void ProcessRolls_ShouldHandleMultipleFiguresCorrectly()
    {
        var game = new YamsGame();
        var rolls = new List<List<int>>
        {
            new List<int> { 6, 6, 6, 6, 6 },
            new List<int> { 2, 3, 4, 5, 6 },
            new List<int> { 3, 3, 3, 5, 5 } 
        };
        var results = game.ProcessRolls(rolls);

        Assert.Equal("Yams", results[0].Figure);  
        Assert.Equal(50, results[0].Points);

        Assert.Equal("GrandeSuite", results[1].Figure);
        Assert.Equal(40, results[1].Points);

        Assert.Equal("Full", results[2].Figure);
        Assert.Equal(30, results[2].Points);
    }

}