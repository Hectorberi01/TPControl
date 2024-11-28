using TPControl;

namespace TestYamsGame;

public class UnitTest1
{
    [Fact]
    public void TestIsYams()
    {
        // Exemple de lancé de Yams
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
}