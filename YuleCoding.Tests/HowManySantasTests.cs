using YuleCoding.Code;

namespace YuleCoding.Tests;

[TestFixture]
public class HowManySantasTests
{
    [Test]
    public void HowManySantas_NoSanta_ReturnsZero()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        int result = yuleMachine.HowManySantas("No Father Christmas here!");

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void HowManySantas_OneSanta_ReturnsOne()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        int result = yuleMachine.HowManySantas("It's said that Santa is a very jolly fellow");

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    [Test]
    public void HowManySantas_TwoSantas_ReturnsTwo()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        int result = yuleMachine.HowManySantas("Santa is the greatest guy - he brings gifts for everybody. Santa is my hero! - Lucy, 8 years old");

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
}
