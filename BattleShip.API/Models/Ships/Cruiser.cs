using System.Xml.Linq;
using BattleShip.API.Utilities;
namespace BattleShip.API.Models.Ships
{
    /// <summary>
    /// Represents the Cruiser ship.
    /// </summary>
    public class Cruiser : Ship
    {
        #region Constructor
        public Cruiser()
        {
            ShipName = "Cruiser";
            BattleShipType = BattleShipType.Cruiser;
            Width = 3;
            Shots = 0;
        }
        #endregion
    }
}
