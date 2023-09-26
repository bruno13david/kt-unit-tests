namespace UnitTests.Models
{
    public interface IVillanin : ICharacter{}

    public class Villanin : Character, IVillanin
    {        
        public Villanin(int x, int y){
            PositionX = x;
            PositionY = y;
        }
    }
}