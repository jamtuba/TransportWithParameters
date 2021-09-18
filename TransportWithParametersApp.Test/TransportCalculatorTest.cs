using Xunit;

namespace TransportWithParametersApp.Test
{
    public class TransportCalculatorTest
    {
        [Theory]
        [InlineData(4, 9, 0)]
        [InlineData(4, 11, 50)]
        [InlineData(5, 9, 75)]
        [InlineData(6, 11, 100)]
        public void Check_TransportExpense_is_Correct(int transportInKm, int weight, int expectedResult)
        {
            // Arrange
            var sut = new Transport();

            // Act
            var result = sut.TransportCalculator(transportInKm, weight);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
