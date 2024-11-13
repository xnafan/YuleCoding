
using System.Text;

namespace YuleCoding.Tests;
[TestFixture]
internal class CreateAsciiSnowTests
{
    [Test]
    public void ReturnsAsciiSnow_WhenValidInput()
    {
        // Arrange
        YuleMachine yuleMachine = new();
        // Act
        var asciiSnow = yuleMachine.CreateAsciiSnow(25, 15, 3);
        // Assert
        var expected = GenerateSnow(25, 15, 3);
        Assert.That(asciiSnow, Is.EqualTo(expected));
    }

    [Test]
    public void ReturnsAsciiSnow_WhenValidInput2()
    {
        // Arrange
        YuleMachine yuleMachine = new();
        // Act
        var asciiSnow = yuleMachine.CreateAsciiSnow(10, 10, 2);
        // Assert
        var expected = GenerateSnow(10, 10, 2);
        Assert.That(asciiSnow, Is.EqualTo(expected));
    }

    [Test]
    public void ThrowsArgumentException_WhenWidthIsLessThan1()
    {
        // Arrange
        YuleMachine yuleMachine = new();
        // Act & Assert
        Assert.Throws<ArgumentException>(() => yuleMachine.CreateAsciiSnow(0, 10, 2));
    }

    [Test]
    public void ThrowsArgumentException_WhenHeightIsLessThan1()
    {
        // Arrange
        YuleMachine yuleMachine = new();
        // Act & Assert
        Assert.Throws<ArgumentException>(() => yuleMachine.CreateAsciiSnow(10, 0, 2));
    }

    private object GenerateSnow(int width, int height, int distanceBetweenSnowFlakes)
    {
        StringBuilder snow = new();
        for (int i = 0; i <= width * height; i++)
        {
            snow.Append(i % distanceBetweenSnowFlakes == 0 ? '*' : ' ');
            if (i > 0 && i % width == 0) { snow.AppendLine(); }
        }
        return snow.ToString();
    }
}
