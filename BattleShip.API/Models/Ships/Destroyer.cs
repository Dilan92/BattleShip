using BattleShip.API.Utilities;
namespace BattleShip.API.Models.Ships
{
    /// <summary>
    /// Represents the Destroyer Ship.
    /// </summary>
    public class Destroyer : Ship
    {
        #region Constructor
        public Destroyer()
        {
            ShipName = "Destroyer";
            BattleShipType = BattleShipType.Destroyer;
            Width = 2;
            Shots = 0;
        }
        #endregion
    }
}
