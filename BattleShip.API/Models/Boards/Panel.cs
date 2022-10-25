using BattleShip.API.Utilities;

namespace BattleShip.API.Models.Boards
{
    /// <summary>
    /// Represents a single square on the game board.
    /// </summary>
    public class Panel
    {
        #region Constructor
        public Panel(int row, int col)
        {
            Coordinates = new Coordinates(row, col);
            BattleShipType = BattleShipType.Empty;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Battle ship type.
        /// </summary>
        public BattleShipType BattleShipType { get; set; }
        /// <summary>
        /// Coordinates.
        /// </summary>
        public Coordinates Coordinates { get; set; }
        /// <summary>
        /// Is panel occupied.
        /// </summary>
        public bool IsPanelOccupied
        {
            get
            {
                return BattleShipType != BattleShipType.Empty;
            }
        }
        #endregion
    }
}
