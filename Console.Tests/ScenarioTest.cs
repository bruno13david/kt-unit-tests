using UnitTests.Enums;
using UnitTests.Models;

namespace Console.Tests;

public class ScenarioTest
{
    private readonly Scenario scenario;

    public ScenarioTest()
    {
        scenario = new Scenario();
    }

    [Fact]
    public void ShouldInitWithMatrix20x20()
    {                        
        Assert.Equal(20, scenario.Width);
        Assert.Equal(20, scenario.Height);
    }

    [Fact]
    public void PersonagemDeveMoverComSucesso()
    {                
        scenario.Width = 20;
        scenario.Height = 20;
        var moveResult = scenario.MovePacman(2,15);

        Assert.Equal(MovePacmanResult.Success, moveResult);
    }

    [Fact]
    public void PersonagemNaoPodeUltrapassarLimiteDaMatriz()
    {                
        var moveResult = scenario.MovePacman(-1,1);
        Assert.Equal(MovePacmanResult.NotPermited, moveResult);
    }

    [Fact]
    public void DeveRetornarFimDeJogoAoColidirComInimigo()
    {                
        scenario.Villains.Add(new Villanin(1, 1));
        var moveResult = scenario.MovePacman(1,1);

        Assert.Equal(MovePacmanResult.EndGame, moveResult);
    }
}