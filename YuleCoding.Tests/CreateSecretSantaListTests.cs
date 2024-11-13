namespace YuleCoding.Tests;

[TestFixture]
internal class CreateSecretSantaListTests
{

    [Test]
    public void CreateSecretSantaList_InvalidNumberOfParticipants_ThrowsArgumentException()
    {

        // Arrange
        var yuleMachine = new YuleMachine();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => yuleMachine.CreateSecretSantaList(new List<string> { "Santa" }));
    }


    [Test]
    public void CreateSecretSantaList_ValidNumberOfParticipants_ReturnsValidSecretSantaSet()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        var result = yuleMachine.CreateSecretSantaList(new List<string> { "Santa", "Mrs Claus", "Elf no. 1", "Elf no. 2", "Elf no. 3" });

        // Assert
        Assert.That(result.Count, Is.EqualTo(5));
        Assert.That(result.Distinct().Count(), Is.EqualTo(5));
        Assert.That(IsCompleteChain(result), Is.True);
    }

    private bool IsCompleteChain(Dictionary<string, string> result)
    {
        var firstPerson = result.First().Key;
        for (var i = 0; i < result.Count; i++)
        {
            if (!result.ContainsKey(firstPerson))
            {
                return false;
            }
            else
            {
                Console.WriteLine($"From:{firstPerson} To: {result[firstPerson]}");
            }
                firstPerson = result[firstPerson];
        }
        return firstPerson == result.First().Key;
    }
}
