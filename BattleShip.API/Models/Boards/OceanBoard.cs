using BattleShip.API.Utilities;
namespace BattleShip.API.Models.Boards
{
    /// <summary>
    /// This is the 10*10 Game board where the ships would be placed
    /// </summary>
    public class OceanBoard : Board
    {
        #region Constructor
        public OceanBoard()
        {
            BoardType = BoardType.Ocean;
            Panels = new List<Panel>();
        }
        #endregion
    }
}

