namespace BattleShip.API.Utilities
{
    /// <summary>
    /// Board types.
    /// </summary>
    public enum BoardType
    {
        Ocean,
        Firing
    }
    /// <summary>
    /// Battle ship types.
    /// </summary>
    public enum BattleShipType
    {
        Empty,
        Carrier,
        Submarine,
        Cruiser,
        Destroyer,
        BattleShip
    }
    /// <summary>
    /// Target types.
    /// </summary>
    public enum TargetType
    {
        Miss,
        Hit
    }
}
