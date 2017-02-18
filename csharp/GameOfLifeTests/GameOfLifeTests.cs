using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class GameOfLifeTests
    {
        [TestMethod]
        public void EnsureICanCreateTheWorld()
        {
        }

        [TestMethod]
        public void EnsureReproductionWithStillLife()
        {

        }

        [TestMethod]
        public void EnsureOverPopulationWithStillLife()
        {

        }

        [TestMethod]
        public void EnsureUnderPopulationWithStillLife()
        {

        }

        [TestMethod]
        public void EnsureLiveOnWithStillLife()
        {

        }

        [TestMethod]
        public void EnsureICanCountLiveNeighbors()
        {
            /*
            int[,] cell_holder = new int[2, 4]; //4-cells each with 2 coordinates
            cell_holder[0, 0] = 17; // X coordinate in my World 
            cell_holder[0, 1] = 17; // Y Coordinate in my World
            */
            // Same as above
            int[,] cell_holder = { { 17, 17 }, { 17, 18 } };

            // Live cell at coordinate (17,17)
            World world = new World(cell_holder);
            

            // Act
            int actual_count = world.CountLiveNighbors(17, 17);
            int expected_count = 1; 
            Assert.AreEqual(expected_count, actual_count);
;        }

        [TestMethod]
        public void EnsureReproductionWithOscillator()
        {

        }

        [TestMethod]
        public void EnsureOverPopulationWithOscillator()
        {

        }

        [TestMethod]
        public void EnsureUnderPopulationWithOscillator()
        {

        }

        [TestMethod]
        public void EnsureLiveOnWithOscillator()
        {

        }

        [TestMethod]
        public void EnsureICanApplyRulesInAnyOrder()
        {

        }


    }
}
