using PuzzleSolutions.Day3;
using Xunit;

namespace PuzzleSolutionsTests.Day3
{
    public class TravelerShould
    {
        [Fact]
        public void Move_To_New_Coordinate()
        {
            var traveler = new Traveler(0, 0);
            var expectedCoordinate = new Coordinate(3, 1);

            var actualCoordinate = traveler.Move(3, 1);

            Assert.Equal(expectedCoordinate, actualCoordinate);
            Assert.Equal(expectedCoordinate, traveler.CurrentCoordinate);
        }
    }
}
