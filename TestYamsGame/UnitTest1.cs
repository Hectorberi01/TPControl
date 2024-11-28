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
    public void IsGrandeSuite()
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
}