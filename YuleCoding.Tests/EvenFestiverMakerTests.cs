namespace YuleCoding.Tests;

[TestFixture]
internal class EvenFestiverMakerTests
{
    [Test]
    public void EvenFestiverMaker_ReplacesRainWithSnow()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        string inputText = "I received the bill in the mail on a rainy day - that made me sad.";

        // Act
        var result = yuleMachine.EvenFestiverMaker(inputText);

        // Assert
        string expected = inputText.Replace("rain", "snow").Replace("sad", "jolly").Replace("bill", "gift"); ;
        Assert.That(result, Is.EqualTo(expected));
    }
}
