namespace UnitTests.Models
{
    public interface ICharacter
    {
        void Move(int x, int y);      
        int GetPositionX();  
        int GetPositionY();  
    }

    public abstract class Character : ICharacter
    {
        public int Life { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public int GetPositionX()
        {
            return PositionX;
        }

        public int GetPositionY()
        {
            return PositionY;
        }

        public void Move(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }        
    }
}