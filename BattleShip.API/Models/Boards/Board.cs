using BattleShip.API.Utilities;

namespace BattleShip.API.Models.Boards
{
    /// <summary>
    /// Represent the Board.
    /// </summary>
    public abstract class Board
    {
        #region Public Properties
        
        /// <summary>
        /// BoardType.
        /// </summary>
        public BoardType BoardType { get; set; }
        /// <summary>
        /// Panels.
        /// </summary>
        public List<Panel>? Panels { get; set; }

        #endregion
    }
}
