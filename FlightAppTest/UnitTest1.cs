using Domain.Tests;
using Xunit;

namespace FlightAppTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Flight flight = new Flight(seatCapacity: 3);
            flight.Book("ngcamukhetha@gmail.com", 1);
            flight.RemainingNumberOfSeats.Should().Be(2);
        }
    }
}