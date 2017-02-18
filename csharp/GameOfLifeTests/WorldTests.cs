using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class WorldTests
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
            LiveCell[] cells = new LiveCell[] { new LiveCell(17, 17), new LiveCell(17, 18) };
            World world = new World(cells);

            int expected_live_neighbors = 1;
            int actual_live_neighbors = world.CountLiveNeighbors(17, 17);

            Assert.AreEqual(expected_live_neighbors, actual_live_neighbors);
        }

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
