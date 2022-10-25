using BattleShip.API.Models.Interfaces;
using BattleShip.API.Models.Boards;
using BattleShip.API.Models.Ships;
using BattleShip.API.Utilities;
using System.Xml.Linq;

namespace BattleShip.API.Models.Players
{
    /// <summary>
    /// Represents the player of the battle ship game.
    /// </summary>
    public class BattleShipPlayer : IBattleShipPlayer
    {
        #region Private Members
        /// <summary>
        /// Ocean board.
        /// </summary>
        private readonly OceanBoard _oceanBoard;
        /// <summary>
        /// Firing board.
        /// </summary>
        private readonly FiringBoard _firingBoard;
        #endregion

        #region Public Properties
        /// <summary>
        /// Name of the player.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ships.
        /// </summary>
        public List<Ship> Ships { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Player
        /// </summary>
        /// <param name="name"></param>
        public BattleShipPlayer(string name)
        {
            Name = name;
            _firingBoard = new FiringBoard();
            _oceanBoard = new OceanBoard();
            Ships = new List<Ship>() { new Ships.BattleShip(), new Carrier(), new Cruiser(), new Destroyer(), new Submarine() };
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Create the board.
        /// </summary>
        public void CreateBoard()
        {
            _oceanBoard.Initiate();
            _firingBoard.Initiate();
        }
        /// <summary>
        /// Place the battle ships.
        /// </summary>
        public void PlaceBattleShips()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            foreach (var ship in Ships)
            {
                bool isOpen = true;
                while (isOpen)
                {
                    var startCol = rand.Next(1, 11);
                    var startRow = rand.Next(1, 11);
                    int endRow = startRow, endcolumn = startCol;
                    var orientation = rand.Next(1, 101) % 2;

                    List<int> cellNumbers = new List<int>();
                    if (orientation == 0)
                    {
                        for (int i = 1; i < ship.Width; i++)
                        {
                            endRow++;
                        }
                    }
                    else
                    {
                        for (int i = 1; i < ship.Width; i++)
                        {
                            endcolumn++;
                        }
                    }

                    if (endRow > 10 || endcolumn > 10)
                    {
                        isOpen = true;
                        continue;
                    }

                    var affectedCells = _oceanBoard.Panels.Range(startRow, startCol, endRow, endcolumn);
                    if (affectedCells.Any(x => x.IsPanelOccupied))
                    {
                        isOpen = true;
                        continue;
                    }
                    ship.ShipCoordinates = new List<Coordinates>();
                    if (orientation == 0)
                    {
                        for (int i = startRow; i <= endRow; i++)
                        {
                            Console.WriteLine(ship.ShipName + " with " + ship.Width + " slots is placed at Row:" + i.ToString() + " and Column:" + startCol.ToString() + ".");
                            ship.ShipCoordinates.Add(new Coordinates(i, startCol));
                        }
                    }
                    else
                    {
                        for (int i = startCol; i <= endcolumn; i++)
                        {
                            Console.WriteLine(ship.ShipName + " with " + ship.Width + " slots is placed at Row:" + i.ToString() + " and Column:" + startCol.ToString() + ".");
                            ship.ShipCoordinates.Add(new Coordinates(i, startCol));
                        }
                    }
                    foreach (var cell in affectedCells)
                    {
                        cell.BattleShipType = ship.BattleShipType;
                    }
                    isOpen = false;
                }
            }
        }
        /// <summary>
        /// Attack the ship.
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public TargetType Attack(Coordinates coordinates)
        {
            var panel = _oceanBoard?.Panels?.GetPanel(coordinates.Row, coordinates.Column);
            if (!panel.IsPanelOccupied)
            {
                Console.WriteLine(" \"Miss!\"");
                return TargetType.Miss;
            }
            var ship = Ships.First(x => x.BattleShipType == panel?.BattleShipType);
            ship.Shots++;
            Console.WriteLine("\"Hit!\"");
            if (ship.IsSunk)
            {
                Console.WriteLine("\"" + ship.ShipName + "!\" is sunk");
            }
            return TargetType.Hit;
        }
        #endregion

    }
}
