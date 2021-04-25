using System.Collections.Generic;
using System.Linq;

namespace PuzzleSolutions.Day3
{
    internal class Map
    {
        private HashSet<MapCoordinate> _coordinates;

        public Map(HashSet<MapCoordinate> mapCoordinateType)
        {
            _coordinates = mapCoordinateType;
        }

        internal MapCoordinateType GetCoordinateType(int x, int y)
        {
            var isInXBounds = x <= GetMaxXCoordinate();
            var isInYBounds = y <= GetMaxYCoordinate();
            return (isInXBounds, isInYBounds) switch
            {
                (true, true) => _coordinates.Single(mapCoordinate => mapCoordinate.Coordinate.X == x &&
                                                                  mapCoordinate.Coordinate.Y == y)
                                            .MapCoordinateType,
                (false, true) => MapCoordinateType.OutOfBoundsX,
                (true, false) => MapCoordinateType.OutOfBoundsY,
                (false, false) => MapCoordinateType.OutOfBoundsY,
            };
        }

        private int GetMaxXCoordinate() => _coordinates.Select(mapCoordinate => mapCoordinate.Coordinate.X).Max();
        private int GetMaxYCoordinate() => _coordinates.Select(mapCoordinate => mapCoordinate.Coordinate.Y).Max();
    }
}