using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleSolutions.Day3;
using Xunit;

namespace PuzzleSolutionsTests.Day3
{
    public class InputAdapterShould
    {
        [Fact]
        public void Build_Map_From_Collection()
        {
            var inputs = new List<string>()
            {
                "..#",
                "#..",
                ".#."
            };

            var map = InputAdapter.BuildMap(inputs);

            Assert.Equal(MapTileType.Empty, map.GetCoordinateType(0, 0));
            Assert.Equal(MapTileType.Empty, map.GetCoordinateType(1, 0));
            Assert.Equal(MapTileType.Tree, map.GetCoordinateType(2, 0));

            Assert.Equal(MapTileType.Tree, map.GetCoordinateType(0, 1));
            Assert.Equal(MapTileType.Empty, map.GetCoordinateType(1, 1));
            Assert.Equal(MapTileType.Empty, map.GetCoordinateType(2, 1));

            Assert.Equal(MapTileType.Empty, map.GetCoordinateType(0, 2));
            Assert.Equal(MapTileType.Tree, map.GetCoordinateType(1, 2));
            Assert.Equal(MapTileType.Empty, map.GetCoordinateType(2, 2));
        }
    }
}
