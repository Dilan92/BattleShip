using BattleShip.API.Models.Boards;

namespace BattleShip.API.Models.Interfaces
{
    /// <summary>
    /// Interface for BattleShipGame.
    /// </summary>
    public interface IBattleShipGame
    {
        #region Public Methods.

        /// <summary>
        /// Attak a ship
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        string Attack(Coordinates coordinates);

        #endregion
    }
}
