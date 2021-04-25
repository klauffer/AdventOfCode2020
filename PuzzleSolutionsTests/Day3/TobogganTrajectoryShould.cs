using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleSolutions.Day3;
using Xunit;

namespace PuzzleSolutionsTests.Day3
{
    public class TobogganTrajectoryShould
    {
        [Fact]
        public void Find_The_Correct_Number_Of_Trees_In_Path()
        {
            var mapCoordinates = new HashSet<MapCoordinate>()
            {
                new MapCoordinate(new Coordinate(0,0), MapCoordinateType.Tree),
                new MapCoordinate(new Coordinate(0,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,1), MapCoordinateType.Tree)
            };
            var map = new Map(mapCoordinates);
            var traveler = new Traveler(0, 0);
            var tobogganTrajectory = new TobogganTrajectory(map, traveler);

            var numberOfTrees = tobogganTrajectory.GetNumberOfTreesInPath();

            Assert.Equal(2, numberOfTrees);
        }
    }
}
