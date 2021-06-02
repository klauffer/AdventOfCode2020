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
            var mapCoordinates = new HashSet<MapTile>()
            {
                new MapTile(new Coordinate(0,0), MapTileType.Empty),
                new MapTile(new Coordinate(1,0), MapTileType.Empty),
                new MapTile(new Coordinate(2,0), MapTileType.Empty),
                new MapTile(new Coordinate(3,0), MapTileType.Empty),
                new MapTile(new Coordinate(4,0), MapTileType.Empty),
                new MapTile(new Coordinate(5,0), MapTileType.Empty),
                new MapTile(new Coordinate(6,0), MapTileType.Empty),

                new MapTile(new Coordinate(0,1), MapTileType.Empty),
                new MapTile(new Coordinate(1,1), MapTileType.Empty),
                new MapTile(new Coordinate(2,1), MapTileType.Empty),
                new MapTile(new Coordinate(3,1), MapTileType.Tree),//should find
                new MapTile(new Coordinate(4,1), MapTileType.Empty),
                new MapTile(new Coordinate(5,1), MapTileType.Empty),
                new MapTile(new Coordinate(6,1), MapTileType.Empty),

                new MapTile(new Coordinate(0,2), MapTileType.Empty),
                new MapTile(new Coordinate(1,2), MapTileType.Empty),
                new MapTile(new Coordinate(2,2), MapTileType.Empty),
                new MapTile(new Coordinate(3,2), MapTileType.Empty),
                new MapTile(new Coordinate(4,2), MapTileType.Empty),
                new MapTile(new Coordinate(5,2), MapTileType.Empty),
                new MapTile(new Coordinate(6,2), MapTileType.Tree),//should find

            };
            var map = new Map(mapCoordinates);
            var tobogganTrajectory = new TobogganTrajectory(map);

            var numberOfTrees = tobogganTrajectory.GetNumberOfTreesInPath();

            Assert.Equal(2, numberOfTrees);
        }

        [Fact]
        public void Not_Find_Trees_Out_Of_Path()
        {
            var mapCoordinates = new HashSet<MapTile>()
            {
                new MapTile(new Coordinate(0,0), MapTileType.Empty),
                new MapTile(new Coordinate(1,0), MapTileType.Empty),
                new MapTile(new Coordinate(2,0), MapTileType.Empty),
                new MapTile(new Coordinate(3,0), MapTileType.Tree),//should not find
                new MapTile(new Coordinate(4,0), MapTileType.Empty),
                new MapTile(new Coordinate(5,0), MapTileType.Empty),
                new MapTile(new Coordinate(6,0), MapTileType.Empty),

                new MapTile(new Coordinate(0,1), MapTileType.Empty),
                new MapTile(new Coordinate(1,1), MapTileType.Empty),
                new MapTile(new Coordinate(2,1), MapTileType.Empty),
                new MapTile(new Coordinate(3,1), MapTileType.Empty),
                new MapTile(new Coordinate(4,1), MapTileType.Empty),
                new MapTile(new Coordinate(5,1), MapTileType.Empty),
                new MapTile(new Coordinate(6,1), MapTileType.Empty),

                new MapTile(new Coordinate(0,2), MapTileType.Empty),
                new MapTile(new Coordinate(1,2), MapTileType.Empty),
                new MapTile(new Coordinate(2,2), MapTileType.Empty),
                new MapTile(new Coordinate(3,2), MapTileType.Empty),
                new MapTile(new Coordinate(4,2), MapTileType.Empty),
                new MapTile(new Coordinate(5,2), MapTileType.Empty),
                new MapTile(new Coordinate(6,2), MapTileType.Tree),//should find

            };
            var map = new Map(mapCoordinates);
            var tobogganTrajectory = new TobogganTrajectory(map);

            var numberOfTrees = tobogganTrajectory.GetNumberOfTreesInPath();

            Assert.Equal(1, numberOfTrees);
        }

        [Fact]
        public void Find_Trees_Path_From_Input()
        {
            var input = new List<String>()
            {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };
            var tobogganTrajectory = TobogganTrajectory.StartPuzzle(input);
            var numberOfTrees = tobogganTrajectory.GetNumberOfTreesInPath();

            Assert.Equal(7, numberOfTrees);
        }

        [Fact]
        public void Find_Trees_In_Multiple_Paths_From_Input()
        {
            var input = new List<String>()
            {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };
            var tobogganTrajectory = TobogganTrajectory.StartPuzzle(input);
            var answer = tobogganTrajectory.GetNumberOfTreesInMultiplePaths();

            Assert.Equal(336, answer);
        }
    }
}
