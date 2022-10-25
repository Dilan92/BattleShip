using BattleShip.API.Utilities;
namespace BattleShip.API.Models.Ships
{
    /// <summary>
    /// Represents the Carrier ship.
    /// </summary>
    public class Carrier : Ship
    {
        #region Constructor
        public Carrier()
        {
            ShipName = "Carrier";
            BattleShipType = BattleShipType.Carrier;
            Width = 5;
            Shots = 0;
        }
        #endregion
    }
}
