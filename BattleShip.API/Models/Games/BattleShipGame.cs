using BattleShip.API.Models.Boards;
using BattleShip.API.Models.Interfaces;
using BattleShip.API.Models.Players;

namespace BattleShip.API.Models.Games
{
    public class BattleShipGame : IBattleShipGame
    {
        #region Public Properties
        /// <summary>
        /// Player one.
        /// </summary>
        public BattleShipPlayer PlayerOne { get; set; }
        #endregion

        #region Constructor
        public BattleShipGame()
        {
            PlayerOne = new BattleShipPlayer("Player One");
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Attak a ship and and report back whether the attack resulted in a hit or a miss.
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public string Attack(Coordinates coordinates)
        {
            return PlayerOne.Attack(coordinates).ToString();
        }
        #endregion
    }
}
