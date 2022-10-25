using BattleShip.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Test
{
    public class ShipTest
    {
        BattleShipController _controller;
        public ShipTest()
        {
            _controller = new BattleShipController();
        }
        [Fact]
        public void ShipsCountValidation()
        {
            int count = 5;
            Assert.Equal(_controller._battleShipGame.PlayerOne.Ships.Count, count);
        }
    }
}
