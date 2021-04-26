using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolutions.Day3
{
    class TobogganTrajectory
    {
        private readonly Map _map;
        private readonly Traveler _traveler;

        public TobogganTrajectory(Map map, Traveler traveler)
        {
            _map = map;
            _traveler = traveler;
        }

        //public static TobogganTrajectory StartQuestion1Journey()
        //{
        //    var map = new Map()
        //}

        public int GetNumberOfTreesInPath()
        {
            var result = 0;
            var mapCoordinateType = MapCoordinateType.Empty;
            var newCoordinate = new Coordinate(0, 0);
            do
            {
                newCoordinate = _traveler.Move(3,1);
                mapCoordinateType = _map.GetCoordinateType(newCoordinate);
                if (mapCoordinateType == MapCoordinateType.Tree)
                {
                    result++;
                }
            } while (mapCoordinateType != MapCoordinateType.OutOfBoundsY);

            return result;
        }
    }
}
