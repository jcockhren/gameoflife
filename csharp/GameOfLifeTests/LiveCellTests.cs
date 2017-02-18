using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class LiveCellTests
    {
        [TestMethod]
        public void EnsureICanCreateInstanceOfLiveCell()
        {
            LiveCell cell = new LiveCell();

            Assert.IsNotNull(cell);
        }

        [TestMethod]
        public void EnsureLiveCellPrintsOutLocation()
        {
            LiveCell cell = new LiveCell(3, 7);
            string expected_text = "(3,7)";
            string actual_text = cell.ToString();
            Assert.AreEqual(expected_text, actual_text);
        }
    }
}
