namespace BattleShip.API.Models.Responses
{
    /// <summary>
    /// Represents the Response error object
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        /// Output whether success or not.
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Output message.
        /// </summary>
        public string Message { get; set; }
    }
}
