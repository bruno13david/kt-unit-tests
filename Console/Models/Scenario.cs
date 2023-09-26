using UnitTests.Enums;

namespace UnitTests.Models
{
    public class Scenario
    {
        public Scenario()
        {
            Width = 20;
            Height = 20;
            Villains = new List<IVillanin>();
            Pacman = new Pacman();
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public IList<IVillanin> Villains { get; set; }
        public IPacman Pacman { get; set; }        

        public MovePacmanResult MovePacman(int x, int y)
        {
            if(Villains.Any(v => v.GetPositionX() == x && v.GetPositionY() == y))
                return MovePacmanResult.EndGame;
            
            if(x >= Width || x < 0 || y >= Height || y < 0)
                return MovePacmanResult.NotPermited;

            Pacman.Move(x, y);
            return MovePacmanResult.Success;
        }
    }
}