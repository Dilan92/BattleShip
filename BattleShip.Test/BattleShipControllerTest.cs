using BattleShip.API.Controllers;
using BattleShip.API.Models.Boards;
using Microsoft.AspNetCore.Mvc;
using BattleShip.API.Utilities;

namespace BattleShip.Test
{
    public class BattleShipControllerTest
    {
        BattleShipController _controller;
        public BattleShipControllerTest()
        {
            _controller = new BattleShipController();
        }
    }
}