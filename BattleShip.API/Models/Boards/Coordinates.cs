using System.Text.Json.Serialization;

namespace BattleShip.API.Models.Boards
{
    /// <summary>
    /// Represent the Coordinates.
    /// </summary>
    public class Coordinates
    {
        #region Public Properties
        /// <summary>
        /// Row of the Panel.
        /// </summary>
        public int Row { get; set; }
        /// <summary>
        /// Column of the Panel.
        /// </summary>
        public int Column { get; set; }
        #endregion

        #region Constructor
        public Coordinates(int row, int col)
        {
            Row = row;
            Column = col;
        }
        #endregion
    }
}
