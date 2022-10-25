using BattleShip.API.Controllers;
using BattleShip.API.Models.Boards;
using BattleShip.API.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Test
{
    public class BoardTest
    {
        BattleShipController _controller;
        OceanBoard _ocean;
        FiringBoard _firing;
        public BoardTest()
        {
            _controller = new BattleShipController();
            _ocean = new OceanBoard();
            _firing = new FiringBoard();
        }
        [Fact]
        public void OceanBoardTypeCreateValidation()
        {
            BoardType ocean = BoardType.Ocean;
            Assert.Equal(_ocean.BoardType, ocean);
        }
        [Fact]
        public void FiringBoardTypeCreateValidation()
        {
            BoardType firing = BoardType.Firing;
            Assert.Equal(_firing.BoardType, firing);
        }
        [Fact]
        public void PanelCountValidation()
        {
            _ocean.Initiate();
            int panelCount = 100;
            Assert.Equal(_ocean.Panels.Count, panelCount);
        }
    }
}
