namespace YuleCoding.Tests;

[TestFixture]
internal class SortGiftsByToAndFromTests
{
    [Test]
    public void SortGiftsByToAndFrom_WhenCalled_ReturnsGiftsSortedByToAndFrom()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        var packages = new List<Gift>
        {
            new Gift { To = "Claire", From = "Bob" },
            new Gift { To = "Bob", From = "Anna" },
            new Gift { To = "Claire", From = "Anna" },
            new Gift { To = "Anna", From = "Derek" },
            new Gift { To = "Derek", From = "Claire" },
            new Gift { To = "Anna", From = "Bob" },
        };

        // Act
        var result = yuleMachine.SortGiftsByToAndFrom(packages);
        result.ToList().ForEach(Console.WriteLine);
        // Assert
        Assert.That(result, Is.EqualTo(new List<Gift>
        {
            new Gift { To = "Anna", From = "Bob" },
            new Gift { To = "Anna", From = "Derek" },
            new Gift { To = "Bob", From = "Anna" },
            new Gift { To = "Claire", From = "Anna" },
            new Gift { To = "Claire", From = "Bob" },
            new Gift { To = "Derek", From = "Claire" },
        }));
    }
}
