namespace UnitTests.Models
{
    public interface IPacman : ICharacter
    {
        void AddLife(int life);
        void RemoveLife(int life);
    }

    public class Pacman : Character, IPacman
    {
        public Pacman(){
            PositionX = 0;
            PositionY = 0;
        }

        public void AddLife(int life)
        {
            throw new NotImplementedException();
        }        

        public void RemoveLife(int life)
        {
            throw new NotImplementedException();
        }
    }
}