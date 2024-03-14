using FluentAssertions;

namespace MarsRover
{
    public class MarsRoversTests
    {
        [Fact]
        public void shouldExistMarsRover()
        {
            (new MarsRoverCar()).Should().NotBeNull();
        }
    }
}