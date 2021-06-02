using System.Collections.Generic;
using System.Linq;

namespace PuzzleSolutions.Day3
{
    internal class Map
    {
        private HashSet<MapTile> _tiles;

        public Map(HashSet<MapTile> mapTile)
        {
            _tiles = mapTile;
        }

        internal MapTileType GetCoordinateType(int x, int y)
        {
            var isInXBounds = x <= GetMaxXCoordinate();
            var isInYBounds = y <= GetMaxYCoordinate();


            return (isInXBounds, isInYBounds) switch
            {
                (true, true) => GetMapTile(x, y).MapTileType,
                (false, true) => GetMapTile(x % (GetMaxXCoordinate()+1), y).MapTileType,
                (true, false) => MapTileType.OutOfBoundsY,
                (false, false) => MapTileType.OutOfBoundsY,
            };
        }

        internal MapTileType GetCoordinateType(Coordinate coordinate) => 
            GetCoordinateType(coordinate.X, coordinate.Y);

        private int GetMaxXCoordinate() => _tiles.Select(mapCoordinate => mapCoordinate.Coordinate.X).Max();
        private int GetMaxYCoordinate() => _tiles.Select(mapCoordinate => mapCoordinate.Coordinate.Y).Max();
        private MapTile GetMapTile(int x, int y) =>
            _tiles.Single(mapCoordinate => mapCoordinate.Coordinate.X == x && mapCoordinate.Coordinate.Y == y);
    }
}