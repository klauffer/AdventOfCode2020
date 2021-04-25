namespace PuzzleSolutions.Day3
{
    internal class Traveler
    {
        public Coordinate CurrentCoordinate { get; private set; }

        public Traveler(int startingXCoordinate, int startingYCoordinate)
        {
            CurrentCoordinate = new Coordinate(startingXCoordinate, startingYCoordinate);
        }

        public Coordinate Move(int x, int y)
        {
            CurrentCoordinate = new Coordinate(CurrentCoordinate.X + x, CurrentCoordinate.Y + y);
            return CurrentCoordinate;
        }
    }
}