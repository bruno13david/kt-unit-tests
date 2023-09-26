using UnitTests.Enums;
using UnitTests.Models;

namespace Console.Tests;

public class PacmanTest
{
    [Fact]
    public void ShouldInitInPosition0x0()
    {                
        var pacman = new Pacman();
        Assert.Equal(0, pacman.PositionX);
        Assert.Equal(0, pacman.PositionY);
    }    
}