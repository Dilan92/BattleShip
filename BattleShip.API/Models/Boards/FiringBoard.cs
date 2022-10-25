using BattleShip.API.Utilities;
namespace BattleShip.API.Models.Boards
{
    /// <summary>
    /// This is the 10*10 Target firing board where the Red/White Pegs get placed notifying Hit/Miss
    /// </summary>
    public class FiringBoard : Board
    {
        #region Constructor
        public FiringBoard()
        {
            BoardType = BoardType.Firing;
            Panels = new List<Panel>();
        }
        #endregion
    }
}
