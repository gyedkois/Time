using Time.Services;
using Xunit;

namespace Time.Tests;

public class TimeProviderTests
{
    [Fact]
    public void GetCurrentTime_ShouldReturnAValidDateTime()
    {
        // Arrange
        var timeProvider = new TimeProvider();

        // Act
        var result = timeProvider.GetCurrentTime();

        // Assert
        Assert.IsType<DateTime>(result);
        Assert.NotEqual(default(DateTime), result);
    }
}