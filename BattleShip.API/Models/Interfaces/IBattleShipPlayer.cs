using BattleShip.API.Models.Boards;
using BattleShip.API.Utilities;

namespace BattleShip.API.Models.Interfaces
{
    /// <summary>
    /// Interface for BattleShipPlayer
    /// </summary>
    public interface IBattleShipPlayer
    {
        #region Public Methods
        /// <summary>
        /// Create the board.
        /// </summary>
        void CreateBoard(); 
        /// <summary>
        /// Place the battle ships.
        /// </summary>
        void PlaceBattleShips();
        /// <summary>
        /// Attack the ship.
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        TargetType Attack(Coordinates coordinates);
        #endregion
    }
}
