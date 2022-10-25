using BattleShip.API.Models.Boards;

namespace BattleShip.API.Utilities
{
    public static class Extensions
    {
        #region Public Methods
        
        /// <summary>
        /// Initiate the board.
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public static Board Initiate(this Board board)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board?.Panels?.Add(new Panel(i, j));
                }
            }
            return board;
        }
        /// <summary>
        /// Gets the range of panels.
        /// </summary>
        /// <param name="panels"></param>
        /// <param name="startRow"></param>
        /// <param name="startColumn"></param>
        /// <param name="endRow"></param>
        /// <param name="endColumn"></param>
        /// <returns></returns>
        public static List<Panel> Range(this List<Panel> panels, int startRow, int startColumn, int endRow, int endColumn)
        {
            return panels.Where(x => x.Coordinates.Row >= startRow
                                     && x.Coordinates.Column >= startColumn
                                     && x.Coordinates.Row <= endRow
                                     && x.Coordinates.Column <= endColumn).ToList();
        }
        /// <summary>
        /// Returns the Panel.
        /// </summary>
        /// <param name="panels"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static Panel GetPanel(this List<Panel> panels, int row, int column)
        {
            return panels.Where(x => x.Coordinates.Row == row && x.Coordinates.Column == column).First();
        }

        #endregion
    }
}
