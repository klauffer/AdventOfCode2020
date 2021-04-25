using System.Collections.Generic;
using PuzzleSolutions.Day3;
using Xunit;

namespace PuzzleSolutionsTests.Day3
{
    public class MapShould
    {
        [Fact]
        public void Get_Correct_MapCoordinateType()
        {
            var mapCoordinates = new HashSet<MapCoordinate>()
            {
                new MapCoordinate(new Coordinate(0,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(0,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,1), MapCoordinateType.Tree)
            };

            var map = new Map(mapCoordinates);

            Assert.Equal(MapCoordinateType.Tree, map.GetCoordinateType(1, 1));
        }

        [Fact]
        public void Inform_If_Out_Of_X_Bounds()
        {
            var mapCoordinates = new HashSet<MapCoordinate>()
            {
                new MapCoordinate(new Coordinate(0,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(0,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,1), MapCoordinateType.Tree)
            };

            var map = new Map(mapCoordinates);
            Assert.Equal(MapCoordinateType.OutOfBoundsX, map.GetCoordinateType(2, 1));
        }

        [Fact]
        public void Inform_If_Out_Of_Y_Bounds()
        {
            var mapCoordinates = new HashSet<MapCoordinate>()
            {
                new MapCoordinate(new Coordinate(0,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(0,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,1), MapCoordinateType.Tree)
            };

            var map = new Map(mapCoordinates);
            Assert.Equal(MapCoordinateType.OutOfBoundsY, map.GetCoordinateType(1, 2));
        }

        [Fact]
        public void Inform_If_Out_Of_Both_X_Y_Bounds()
        {
            var mapCoordinates = new HashSet<MapCoordinate>()
            {
                new MapCoordinate(new Coordinate(0,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(0,1), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,0), MapCoordinateType.Empty),
                new MapCoordinate(new Coordinate(1,1), MapCoordinateType.Tree)
            };

            var map = new Map(mapCoordinates);
            Assert.Equal(MapCoordinateType.OutOfBoundsY, map.GetCoordinateType(2, 2));
        }
    }
}
