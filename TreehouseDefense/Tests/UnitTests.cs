﻿using Xunit;

namespace TreehouseDefense.Tests
{
    public class PointTests
    {
        [Fact]
        public void PointTest()
        {
            int x = 5;
            int y = 6;
            var point = new Point(x, y);

            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
        }

        [Fact]
        public void DistanceToWithPathagoreanTriple()
        {
            var point = new Point(3, 4);
            var target = new Point(0, 0);

            var expected = 5.0;
            var actual = target.DistanceTo(point);

            Assert.Equal(expected, actual, 2);
        }    
        
        [Fact]
        public void DistanceToSameLocationReturnsZero()
        {
            var point = new Point(3, 4);
            var target = new Point(3, 4);

            var expected = 0.0;
            var actual = target.DistanceTo(point);

            Assert.Equal(expected, actual, 2);
        }
    }
}
