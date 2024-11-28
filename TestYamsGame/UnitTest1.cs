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
        var game = new YamsGame();

        Assert.True(game.IsYams(yamsList));
        Assert.False(game.IsYams(yamsList2));
    }
}