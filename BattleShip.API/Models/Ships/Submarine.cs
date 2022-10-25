using BattleShip.API.Utilities;
namespace BattleShip.API.Models.Ships
{
    /// <summary>
    /// Represents the Submarine ship.
    /// </summary>
    public class Submarine : Ship
    {
        #region Constructor
        public Submarine()
        {
            ShipName = "Submarine";
            BattleShipType = BattleShipType.Destroyer;
            Width = 3;
            Shots = 0;
        }
        #endregion
    }
}
