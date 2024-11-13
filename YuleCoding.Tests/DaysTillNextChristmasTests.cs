namespace YuleCoding.Tests;
[TestFixture]
internal class DaysTillNextChristmasTests
{
    [Test]
    public void DaysTillChristmas_WhenCalled_ReturnsDaysTillChristmas()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        int result = yuleMachine.DaysTillNextChristmas();

        // Assert
        int expected = DaysTillChristmas();
        Assert.That(result, Is.EqualTo(expected));
    }

    private int DaysTillChristmas()
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        if (today.Month == 12 && today.Day == 24) { return 0; }
        int nextChristMasYear = today.Year;
        if (today.Month == 12 && today.Day > 24) { nextChristMasYear++; }
        DateOnly nextChristmasDate = new DateOnly(nextChristMasYear, 12, 24);
        return nextChristmasDate.DayNumber - today.DayNumber;
    }
}
