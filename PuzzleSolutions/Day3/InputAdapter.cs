using System.Collections.Generic;
using System.Linq;

namespace PuzzleSolutions.Day3
{
    internal static class InputAdapter
    {
        internal static Map BuildMap(IEnumerable<string> input)
        {
            var mapTiles = new HashSet<MapTile>();
            for (int i = 0; i < input.Count(); i++)
            {
                var row = input.ElementAt(i);
                mapTiles.UnionWith(BuildRow(row, i));
            }
            return new Map(mapTiles);
        }

        private static IEnumerable<MapTile> BuildRow(string row, int rowIndex)
        {
            var mapTiles = new List<MapTile>();
            for (int columnIndex = 0; columnIndex < row.Length; columnIndex++)
            {
                var tileTypeChar = row.ElementAt(columnIndex);
                var mapTileType = tileTypeChar switch
                {
                    '.' => MapTileType.Empty,
                    '#' => MapTileType.Tree,
                    _ => MapTileType.Empty
                };
                var coordinate = new Coordinate(columnIndex, rowIndex);
                mapTiles.Add(new MapTile(coordinate, mapTileType));
            }
            return mapTiles;
        }
    }
}
