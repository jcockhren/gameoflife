using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class WorldTests
    {
        [TestMethod]
        public void TestWorldExist()
        {
            World myWorld = new World();
            Assert.IsNotNull(myWorld);
        }

          [TestMethod]
        public void EnsureReproductionWithStillLife()
        {
            int[,] cell_holder = { { 17, 17 }, { 17, 18 }, { 17, 19 } };

            World world = new World(cell_holder);
            world.Reproduction(world);
            // Act
            var actual = world.about_to_born;
            var expected = new List<string>() { "(16,18)", "(18,18)"};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureOverPopulationWithStillLife()
        {
            int[,] cell_holder = { { 17, 17 }, { 17, 18 }, { 17, 19 }, { 16, 18}, { 18, 18} };

            World world = new World(cell_holder);
            world.OverPopolation(world);
            // Act
            var actual = world.about_to_die;
            var expected = new List<string>() { "(17,18)" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureUnderPopulationWithStillLife()
        {
            int[,] cell_holder = { { 17, 17 }, { 17, 18 }, { 17, 19 } };

            World world = new World(cell_holder);
            world.UnderPopulation(world);
            // Act
            var actual = world.about_to_die;
            var expected = new List<string>() { "(17,17)", "(17,19)" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureLiveOnWithStillLife()
        {

        }

        [TestMethod]
        public void EnsureICanCountLiveNeighbors()
        {
            /*
            int[,] cell_holder = new int[4, 2]; //4-cells each with 2 coordinates
            cell_holder[0, 0] = 17; // X coordinate in my World 
            cell_holder[0, 1] = 17; // Y Coordinate in my World
            */
            // Same as above
            int[,] cell_holder = { { 17, 17 }, { 17, 18 }, {17, 19 } };

            // Live cell at coordinate (17,17)
            World world = new World(cell_holder);
            

            // Act
            int actual_count = world.CountLiveNeighbors(16, 18);
            int expected_count = 3; 
            Assert.AreEqual(expected_count, actual_count);
        }

        [TestMethod]
        public void EnsureReproductionWithOscillator()
        {
            int[,] cell_holder = { { 17, 17 }, { 17, 18 }, { 17, 19 } };

            World world = new World(cell_holder);
            world.Tick();
            // Act
            var actual = world.worldArr[18, 18];

            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureOverPopulationWithOscillator()
        {
            int[,] cell_holder = { { 17, 17 }, { 17, 18 }, { 17, 19 }, { 16, 18 }, { 18, 18 } };

            World world = new World(cell_holder);
            world.Tick();
            // Act
            var actual = world.worldArr[17, 18];

            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureUnderPopulationWithOscillator()
        {
            int[,] cell_holder = { { 17, 17 }, { 17, 18 }, { 17, 19 } };

            World world = new World(cell_holder);
            world.Tick();
            // Act
            var actual = world.worldArr[17, 17];

            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureLiveOnWithOscillator()
        {
            int[,] cell_holder = { { 17, 17 }, { 17, 18 }, { 17, 19 } };

            World world = new World(cell_holder);
            world.Tick();
            // Act
            var actual = world.worldArr[17, 18];

            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureICanApplyRulesInAnyOrder()
        {
            int[,] cell_holder = { { 17, 17 }, { 17, 18 }, { 17, 19 } };

            World world = new World(cell_holder);

            // Act
            world.UnderPopulation(world);
            world.Reproduction(world);
            world.LiveOn(world);
            world.OverPopolation(world);

            var actual = world.about_to_born;
            var expected = new List<string>() { "(16,18)", "(18,18)" };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
