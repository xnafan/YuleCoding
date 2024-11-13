namespace YuleCoding.Tests;

[TestFixture]
internal class ChristmasRaffleDrawTests
{
    [Test]
    public void ThrowsArgumentException_WhenNoParticipants()
    {
        // Arrange
        YuleMachine yuleMachine = new();
        List<string> participants = new();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => yuleMachine.DrawChristmasRaffleWinners(participants, 3));
    }

    [Test]
    public void ThrowsArgumentException_WhenNoWinners()
    {
        // Arrange
        YuleMachine yuleMachine = new();
        List<string> participants = new() { "Alice", "Bob", "Charlie" };
        // Act & Assert
        Assert.Throws<ArgumentException>(() => yuleMachine.DrawChristmasRaffleWinners(participants, 0));
    }

    [Test]
    public void ThrowsArgumentException_WhenNotEnoughParticipants()
    {
        // Arrange
        YuleMachine yuleMachine = new();
        List<string> participants = new() { "Alice", "Bob", "Charlie" };
        // Act & Assert
        Assert.Throws<ArgumentException>(() => yuleMachine.DrawChristmasRaffleWinners(participants, 4));
    }

    [Test]
    public void ReturnsWinners_WhenParticipantsAndWinnersAreValid()
    {
        // Arrange
        YuleMachine yuleMachine = new();
        List<string> participants = new() { "Alice", "Bob", "Charlie", "Dora" };
        // Act
        var winners = yuleMachine.DrawChristmasRaffleWinners(participants, 2);
        // Assert
        Assert.That(winners.Count(), Is.EqualTo(2));
        Assert.That(winners.Distinct().Count(), Is.EqualTo(2));
    }
}