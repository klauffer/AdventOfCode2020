using System.Collections.Generic;
using System.Linq;

namespace PuzzleSolutions.Day3
{
    public sealed class TobogganTrajectory
    {
        private readonly Map _map;

        public static TobogganTrajectory StartPuzzle(IEnumerable<string> input)
        {
            var map = InputAdapter.BuildMap(input);
            return new TobogganTrajectory(map);
        }

        internal TobogganTrajectory(Map map)
        {
            _map = map;
        }

        public int GetNumberOfTreesInPath()
        {
            var numberOfTreesInPath = 0;
            var mapCoordinateType = MapTileType.Empty;
            var newCoordinate = new Coordinate(0, 0);
            var traveler = new Traveler(0, 0);
            do
            {
                newCoordinate = traveler.Move(3,1);
                mapCoordinateType = _map.GetCoordinateType(newCoordinate);
                if (mapCoordinateType == MapTileType.Tree)
                {
                    numberOfTreesInPath++;
                }
            } while (mapCoordinateType != MapTileType.OutOfBoundsY);

            return numberOfTreesInPath;
        }

        public double GetNumberOfTreesInMultiplePaths()
        {
            var pathPatterns = new List<Coordinate>()
            {
                new Coordinate(1,1),
                new Coordinate(3,1),
                new Coordinate(5,1),
                new Coordinate(7,1),
                new Coordinate(1,2),
            };
            var numberOfTreesInEachPath = new List<double>();
            foreach (var pathPattern in pathPatterns)
            {
                var numberOfTreesInPath = 0;
                var mapCoordinateType = MapTileType.Empty;
                var newCoordinate = new Coordinate(0, 0);
                var traveler = new Traveler(0, 0);
                do
                {
                    newCoordinate = traveler.Move(pathPattern.X, pathPattern.Y);
                    mapCoordinateType = _map.GetCoordinateType(newCoordinate);
                    if (mapCoordinateType == MapTileType.Tree)
                    {
                        numberOfTreesInPath++;
                    }
                } while (mapCoordinateType != MapTileType.OutOfBoundsY);
                numberOfTreesInEachPath.Add(numberOfTreesInPath);
            }
            double answer = numberOfTreesInEachPath.Aggregate((a, x) => a * x);
            return answer;
        }

    }
}
