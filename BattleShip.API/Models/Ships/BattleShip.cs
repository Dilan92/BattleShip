using System.Xml.Linq;
using BattleShip.API.Utilities;
namespace BattleShip.API.Models.Ships
{
    /// <summary>
    /// Represent the Battle ship.
    /// </summary>
    public class BattleShip : Ship
    {
        #region Constructor
        public BattleShip()
        {
            ShipName = "BattleShip";
            BattleShipType = BattleShipType.BattleShip;
            Width = 4;
            Shots = 0;
        }
        #endregion
    }
}
