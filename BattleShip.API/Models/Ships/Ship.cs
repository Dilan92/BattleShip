using BattleShip.API.Models.Boards;
using BattleShip.API.Utilities;

namespace BattleShip.API.Models.Ships
{
    /// <summary>
    /// Represents the Ship.
    /// </summary>
    public abstract class Ship
    {
        #region Public Properties
        /// <summary>
        /// Name of the ship.
        /// </summary>
        public string ShipName { get; set; }
        /// <summary>
        /// Type of the battle ship.
        /// </summary>
        public BattleShipType BattleShipType { get; set; }
        /// <summary>
        /// Coordinates of the ship.
        /// </summary>
        public List<Coordinates> ShipCoordinates { get; set; }
        /// <summary>
        /// Number of hits.
        /// </summary>
        public int Shots { get; set; }
        /// <summary>
        /// Width of the ship in panels.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Check if the ship is sunk.
        /// </summary>
        public bool IsSunk
        {
            get
            {
                return Shots >= Width;
            }
        }
        #endregion
    }
}
