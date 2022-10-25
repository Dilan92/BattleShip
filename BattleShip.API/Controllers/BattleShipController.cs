using BattleShip.API.Models.Boards;
using BattleShip.API.Models.Games;
using BattleShip.API.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BattleShip.API.Controllers
{
    /// <summary>
    /// Represent the actions related to Battle Ship Game.
    /// </summary>
    [Route("BattleShip")]
    [ApiController]
    public class BattleShipController : ControllerBase
    {
        #region Public Members
        /// <summary>
        /// Battle ship game
        /// </summary>
        public readonly BattleShipGame _battleShipGame;
        #endregion

        #region Constructor
        public BattleShipController()
        {
            this._battleShipGame = new BattleShipGame();
        }
        #endregion

        #region Action Methods
        /// <summary>
        /// Create the board
        /// </summary>
        [HttpGet]
        [Route("/api/create-a-board")]
        [SwaggerOperation("createBoard")]
        public void CreateBoard()
        {
            _battleShipGame.PlayerOne.CreateBoard();
        }

        /// <summary>
        /// Place the battle ships.
        /// </summary>
        [HttpPut]
        [Route("/api/place-battleships")]
        [SwaggerOperation("placeBattleShips")]
        public void PlaceBattleShips()
        {
            _battleShipGame.PlayerOne.PlaceBattleShips();
        }

        /// <summary>
        /// Attack a ship.
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/attack")]
        [SwaggerOperation("Attack")]
        public string Attack([FromBody]Coordinates coordinates)
        {
            Console.WriteLine("\"Firing shot at " + coordinates.Row.ToString() + ", " + coordinates.Column.ToString() + "\"");
            var result = _battleShipGame.Attack(coordinates);
            if (String.IsNullOrEmpty(result))
                throw new ApplicationException("Invalid output.");
            return result;
        }
        #endregion
    }
}
