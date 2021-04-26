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
                new MapCoordinate(new Coordinate(0,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(2,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(3,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(4,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(5,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(6,0), MapCoordinateType.Empty),

                new MapCoordinate(new Coordinate(0,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(2,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(3,1), MapCoordinateType.Tree),//should find
                new MapCoordinate(new Coordinate(4,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(5,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(6,1), MapCoordinateType.Empty),

                new MapCoordinate(new Coordinate(0,2), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,2), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(2,2), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(3,2), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(4,2), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(5,2), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(6,2), MapCoordinateType.Tree),//should find

            };
            var map = new Map(mapCoordinates);
            var traveler = new Traveler(0, 0);
            var tobogganTrajectory = new TobogganTrajectory(map, traveler);

            var numberOfTrees = tobogganTrajectory.GetNumberOfTreesInPath();

            Assert.Equal(2, numberOfTrees);
        }

        [Fact]
        public void Not_Find_Trees_Out_Of_Path()
        {
            var mapCoordinates = new HashSet<MapCoordinate>()
            {
                new MapCoordinate(new Coordinate(0,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(2,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(3,0), MapCoordinateType.Tree),//should not find
                new MapCoordinate(new Coordinate(4,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(5,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(6,0), MapCoordinateType.Empty),

                new MapCoordinate(new Coordinate(0,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(2,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(3,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(4,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(5,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(6,1), MapCoordinateType.Empty),

                new MapCoordinate(new Coordinate(0,2), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,2), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(2,2), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(3,2), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(4,2), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(5,2), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(6,2), MapCoordinateType.Tree),//should find

            };
            var map = new Map(mapCoordinates);
            var traveler = new Traveler(0, 0);
            var tobogganTrajectory = new TobogganTrajectory(map, traveler);

            var numberOfTrees = tobogganTrajectory.GetNumberOfTreesInPath();

            Assert.Equal(1, numberOfTrees);
        }
    }
}
