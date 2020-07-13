﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorBasedDrawing.src.ApplicationCore.Entities;

namespace VectorBasedDrawing.UnitTests.tests.UnitTests.ApplicationCore.Entities
{
    [TestClass]
    public class SquareTests
    {
        private readonly int _x = 42;
        private readonly int _y = 11;
        private readonly int _size = 44;

        [TestMethod]
        public void TestSquareInitialization()
        {
            var square = new Square(_x, _y, _size);

            Assert.AreEqual(_x, square.X);
            Assert.AreEqual(_y, square.Y);
            Assert.AreEqual(_size, square.Size);
        }
    }
}
