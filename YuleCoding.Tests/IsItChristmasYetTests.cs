using YuleCoding.Code;
namespace YuleCoding.Tests;

[TestFixture]
public class IsItChristmasYetTests
{
    [Test]
    public void IsItChristmasYet_Before24th_ReturnsNotYet()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act & Assert
        Assert.That(yuleMachine.IsItChristmasYet(1), Is.EqualTo("Not yet!"));
        Assert.That(yuleMachine.IsItChristmasYet(10), Is.EqualTo("Not yet!"));
        Assert.That(yuleMachine.IsItChristmasYet(22), Is.EqualTo("Not yet!"));
    }

    [Test]
    public void IsItChristmasYet_On24th_ReturnsYes()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        string result = yuleMachine.IsItChristmasYet(24);

        // Assert
        Assert.That(result, Is.EqualTo("Yes!"));
    }

    [Test]
    public void IsItChristmasYet_After24th_ReturnsItsOver()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act & Assert
        Assert.That(yuleMachine.IsItChristmasYet(25), Is.EqualTo("It's over!"));
        Assert.That(yuleMachine.IsItChristmasYet(31), Is.EqualTo("It's over!"));
    }
}