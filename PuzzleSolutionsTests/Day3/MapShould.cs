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
            var mapTiles = new HashSet<MapTile>()
            {
                new MapTile(new Coordinate(0,0), MapTileType.Empty),
                new MapTile(new Coordinate(0,1), MapTileType.Empty),
                new MapTile(new Coordinate(1,0), MapTileType.Empty),
                new MapTile(new Coordinate(1,1), MapTileType.Tree)
            };

            var map = new Map(mapTiles);

            Assert.Equal(MapTileType.Tree, map.GetCoordinateType(1, 1));
        }

        [Fact]
        public void Get_Correct_MapCoordinateType_Using_Coordinate()
        {
            var mapTiles = new HashSet<MapTile>()
            {
                new MapTile(new Coordinate(0,0), MapTileType.Empty),
                new MapTile(new Coordinate(0,1), MapTileType.Empty),
                new MapTile(new Coordinate(1,0), MapTileType.Empty),
                new MapTile(new Coordinate(1,1), MapTileType.Tree)
            };

            var map = new Map(mapTiles);

            Assert.Equal(MapTileType.Tree, map.GetCoordinateType(new Coordinate(1, 1)));
        }

        //[Fact]
        //public void Inform_If_Out_Of_X_Bounds()
        //{
        //    var mapTiles = new HashSet<MapCoordinate>()
        //    {
        //        new MapCoordinate(new Coordinate(0,0), MapCoordinateType.Empty),
        //        new MapCoordinate(new Coordinate(0,1), MapCoordinateType.Empty),
        //        new MapCoordinate(new Coordinate(1,0), MapCoordinateType.Empty),
        //        new MapCoordinate(new Coordinate(1,1), MapCoordinateType.Tree)
        //    };

        //    var map = new Map(mapTiles);
        //    Assert.Equal(MapCoordinateType.OutOfBoundsX, map.GetCoordinateType(2, 1));
        //}

        [Fact]
        public void Expand_X_Axis()
        {
            var mapTiles = new HashSet<MapTile>()
            {
                new MapTile(new Coordinate(0,0), MapTileType.Empty),
                new MapTile(new Coordinate(1,0), MapTileType.Empty),
                new MapTile(new Coordinate(0,1), MapTileType.Empty),
                new MapTile(new Coordinate(1,1), MapTileType.Tree)
            };

            var map = new Map(mapTiles);
            Assert.Equal(MapTileType.Empty, map.GetCoordinateType(2, 0));
        }

        [Fact]
        public void Expand_X_Axis_And_Find_Tree()
        {
            var mapTiles = new HashSet<MapTile>()
            {
                new MapTile(new Coordinate(0,0), MapTileType.Empty),
                new MapTile(new Coordinate(1,0), MapTileType.Empty),
                new MapTile(new Coordinate(0,1), MapTileType.Empty),
                new MapTile(new Coordinate(1,1), MapTileType.Tree)
            };

            var map = new Map(mapTiles);
            Assert.Equal(MapTileType.Tree, map.GetCoordinateType(3, 1));
        }

        [Fact]
        public void Inform_If_Out_Of_Y_Bounds()
        {
            var mapTiles = new HashSet<MapTile>()
            {
                new MapTile(new Coordinate(0,0), MapTileType.Empty),
                new MapTile(new Coordinate(0,1), MapTileType.Empty),
                new MapTile(new Coordinate(1,0), MapTileType.Empty),
                new MapTile(new Coordinate(1,1), MapTileType.Tree)
            };

            var map = new Map(mapTiles);
            Assert.Equal(MapTileType.OutOfBoundsY, map.GetCoordinateType(1, 2));
        }

        [Fact]
        public void Inform_If_Out_Of_Both_X_Y_Bounds()
        {
            var mapTiles = new HashSet<MapTile>()
            {
                new MapTile(new Coordinate(0,0), MapTileType.Empty),
                new MapTile(new Coordinate(0,1), MapTileType.Empty),
                new MapTile(new Coordinate(1,0), MapTileType.Empty),
                new MapTile(new Coordinate(1,1), MapTileType.Tree)
            };

            var map = new Map(mapTiles);
            Assert.Equal(MapTileType.OutOfBoundsY, map.GetCoordinateType(2, 2));
        }
    }
}
