namespace YuleCoding.Tests;
[TestFixture]
internal class SortSantasReindeerTests
{
    [Test]
    public void SortSantasReindeer_ShouldReturnReindeerInAlphabeticalOrder()
    {
        // Arrange
        var reindeer = new List<string> { "Dasher", "Dancer", "Prancer", "Vixen", "Comet", "Cupid", "Donner", "Blitzen", "Rudolph" };
        var yuleMachine = new YuleMachine();

        // Act
        var sortedReindeer = yuleMachine.SortSantasReindeer(reindeer).ToList();

        // Assert
        Assert.That(sortedReindeer[0], Is.EqualTo("Rudolph"));
        Assert.That(sortedReindeer[1], Is.EqualTo("Blitzen"));
        Assert.That(sortedReindeer[2], Is.EqualTo("Comet"));
        Assert.That(sortedReindeer[3], Is.EqualTo("Cupid"));
        Assert.That(sortedReindeer[4], Is.EqualTo("Dancer"));
        Assert.That(sortedReindeer[5], Is.EqualTo("Dasher"));
        Assert.That(sortedReindeer[6], Is.EqualTo("Donner"));
        Assert.That(sortedReindeer[7], Is.EqualTo("Prancer"));
        Assert.That(sortedReindeer[8], Is.EqualTo("Vixen"));
    }

    [Test]
    public void SortSantasReindeer_ShouldReturnReindeerInAlphabeticalOrderWithoutRudolph()
    {
        // Arrange
        var reindeer = new List<string> { "Dasher", "Dancer", "Prancer", "Vixen", "Comet", "Cupid", "Donner", "Blitzen" };
        var yuleMachine = new YuleMachine();

        // Act
        var sortedReindeer = yuleMachine.SortSantasReindeer(reindeer).ToList();

        // Assert
        Assert.That(sortedReindeer[0], Is.EqualTo("Blitzen"));
        Assert.That(sortedReindeer[1], Is.EqualTo("Comet"));
        Assert.That(sortedReindeer[2], Is.EqualTo("Cupid"));
        Assert.That(sortedReindeer[3], Is.EqualTo("Dancer"));
        Assert.That(sortedReindeer[4], Is.EqualTo("Dasher"));
        Assert.That(sortedReindeer[5], Is.EqualTo("Donner"));
        Assert.That(sortedReindeer[6], Is.EqualTo("Prancer"));
        Assert.That(sortedReindeer[7], Is.EqualTo("Vixen"));
    }

}
