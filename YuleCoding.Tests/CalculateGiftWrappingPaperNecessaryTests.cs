namespace YuleCoding.Tests;
[TestFixture]
internal class CalculateGiftWrappingPaperNecessaryTests
{
    [Test]
    public void CalculateGiftWrappingPaperNecessary_WhenGivenLengthWidthHeight_ShouldReturnCorrectAmount()
    {
        // Arrange
        var length = 2;
        var width = 3;
        var height = 4;
        YuleMachine yuleMachine = new();
        // Act
        var result = yuleMachine.CalculateAmountOfGiftWrappingPaperNecessary(length, width, height);
        // Assert
        var expected = 52;
        Assert.That(result, Is.EqualTo(expected));
    }
}
