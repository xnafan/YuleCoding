namespace YuleCoding.Tests;

[TestFixture]
public class ChristmasGreetingTests
{
    [Test]
    public void ChristmasGreeting_ShouldReturnCorrectGreeting()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        string name = "John";

        // Act
        string result = yuleMachine.ChristmasGreeting(name);

        // Assert
        var expected = "Merry Christmas, John";
        Assert.That(result, Is.EqualTo(expected), $"The greeting was not correctly formatted. Should be '{expected}', but was '{result}'.");
    }
}