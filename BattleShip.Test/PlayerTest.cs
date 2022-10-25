using BattleShip.API.Controllers;
using BattleShip.API.Models.Boards;
using BattleShip.API.Models.Interfaces;
using BattleShip.API.Models.Players;
using BattleShip.API.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Test
{
    public class PlayerTest
    {
        BattleShipController _controller;
        public PlayerTest()
        {
            _controller = new BattleShipController();
        }
        [Fact]
        public void PlayerValidation()
        {
            string playerOne = "Player One";
            Assert.Equal(_controller._battleShipGame.PlayerOne.Name, playerOne);
        }
        [Theory]
        [InlineData("Player One", TargetType.Hit)]
        [InlineData("Player One", TargetType.Miss)]
        public void FireShotCalidation(string name, TargetType shotType)
        {
            BattleShipPlayer player = new BattleShipPlayer(name);
            player.CreateBoard();
            player.PlaceBattleShips();
            Coordinates coords = new Coordinates(4, 7);
            Assert.Equal(player.Attack(coords), shotType);
        }
    }
}
