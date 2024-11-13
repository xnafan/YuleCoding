using YuleCoding.Code;

namespace YuleCoding.Tests;

[TestFixture]
internal class WhosPositiveTests
{
    [Test]
    public void WhosPositive_EmptyList_ReturnsZero()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        int result = yuleMachine.WhosPositive(new List<int>());

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }


    [Test]
    public void WhosPositive_AllPositiveNumbers_ReturnsCount()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        int result = yuleMachine.WhosPositive(new List<int> { 1, 2, 3, 4, 5 });

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void WhosPositive_AllNegativeNumbers_ReturnsZero()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        int result = yuleMachine.WhosPositive(new List<int> { -1, -2, -3, -4, -5 });

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void WhosPositive_MixedNumbers_ReturnsCount()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        int result = yuleMachine.WhosPositive(new List<int> { -1, 2, -3, 4, -5 });

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
}