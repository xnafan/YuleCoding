namespace YuleCoding.Tests;

[TestFixture]
internal class ChristmasPoemCheckerTests
{
    [Test]
    public void ChristmasPoemChecker_PoemContainsSantaCodeAndSnow_ReturnsTrue()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        bool result = yuleMachine.ChristmasPoemChecker(

        @"In the glow of code, where dreams deploy,
        Amid loops and logic, there’s Christmas joy.
        With each line crafted, bugs we sift,
        Building apps—a coder's gift.

        Snowflakes fall on keys that clatter,
        Debugging tales and data that matter.
        Snow drifts outside, but warm inside,
        We code with joy, with festive pride.

        A gift of code, shared far and near,
        Brings smiles of joy, spreads holiday cheer.
        The snow glistens, pure and bright,
        As code runs smooth on this winter night.

        From nested loops to functions' light,
        The gift of learning shines so right.
        Snow and joy in every part,
        Coding Christmas, a work of heart.");

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void ChristmasPoemChecker_PoemContainsSantaCodeButNotSnow_ReturnsFalse()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        bool result = yuleMachine.ChristmasPoemChecker("SantA cOdE");

        // Assert
        Assert.That(result, Is.False);
    }
}