namespace YuleCoding.Tests;
[TestFixture]
internal class CalculateSantaLetterNicenessTests
{
    [Test]
    public void CalculateSantaLetterNiceness_WithNiceLetter_Returns12()
    {
        // Arrange
        YuleMachine yuleMachine = new();
        // Act
        string santaLetter = "Dear Santa, please bring me a new toy. Thank you for being so kind. Please make this a wonderful Christmas. Thank you!";

        int result = yuleMachine.CalculateSantaLetterNiceness(santaLetter);

        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
    [Test]
    public void CalculateSantaLetterNiceness_WithNaughtyLetter_Returns0()
    {
        // Arrange
        YuleMachine yuleMachine = new();
        // Act
        string santaLetter = "Dear Santa, I hate you. I want tons of presents - or else!. You are the worst. I hope you get stuck in a chimney. Bye.";
        int result = yuleMachine.CalculateSantaLetterNiceness(santaLetter);
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
}
