namespace YuleCoding.Tests;

[TestFixture]
internal class FestiveMakerTests
{
    [Test]
    public void FestiveMaker_WhenGivenText_ReturnsTextWithChristmasTrees()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        var text = "Hello You Jolly Yule Coders!";

        // Act
        var result = yuleMachine.FestiveMaker(text);

        // Assert
        Assert.That(result, Is.EqualTo("Hello🎄You🎄Jolly🎄Yule🎄Coders!"));
    }
}
