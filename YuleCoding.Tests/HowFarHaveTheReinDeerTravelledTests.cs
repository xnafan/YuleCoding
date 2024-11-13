namespace YuleCoding.Tests;

[TestFixture]
internal class HowFarHaveTheReinDeerTravelledTests
{

    [Test]
    public void HowFarHaveTheReinDeerTravelled_WhenGivenDistances_ReturnsTotalDistance()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        var distances = new List<Mood> { Mood.Sleeping, Mood.Drowsy , Mood.Fresh , Mood.Happy, Mood.Drunk , Mood.Hungover, Mood.Drowsy, Mood.Happy };

        // Act
        var result = yuleMachine.HowFarHaveTheReinDeerTravelled(distances);

        // Assert
        Assert.That(result, Is.EqualTo(7));
    }
}
