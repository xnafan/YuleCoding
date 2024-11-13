using YuleCoding.Code;

namespace YuleCoding.Tests;

[TestFixture]
internal class ChristmasCountingTests
{
    [Test]
    public void ChristmasCounting_LessThan1_ReturnsBahHumbug()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        string result = yuleMachine.ChristmasCounting(0);

        // Assert
        Assert.That(result, Is.EqualTo("BAH, Humbug!"));
    }
    [Test]
    public void ChristmasCounting_MoreThan24_ReturnsBahHumbug()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        string result = yuleMachine.ChristmasCounting(25);

        // Assert
        Assert.That(result, Is.EqualTo("BAH, Humbug!"));
    }
    [Test]
    public void ChristmasCounting_DivisibleBy3_ReturnsHo()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        string result = yuleMachine.ChristmasCounting(3);

        // Assert
        Assert.That(result, Is.EqualTo("Ho"));
    }

    [Test]
    public void ChristmasCounting_DivisibleBy5_ReturnsHoHo()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        string result = yuleMachine.ChristmasCounting(5);

        // Assert
        Assert.That(result, Is.EqualTo("HoHo"));
    }

    [Test]
    public void ChristmasCounting_DivisibleBy3And5_ReturnsHappyHolidays()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        string result = yuleMachine.ChristmasCounting(15);

        // Assert
        Assert.That(result, Is.EqualTo("Happy Holidays!"));
    }

    [Test]
    public void ChristmasCounting_NotDivisibleBy3Or5_ReturnsNumber()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        string result = yuleMachine.ChristmasCounting(19);

        // Assert
        Assert.That(result, Is.EqualTo("19"));
    }
}
