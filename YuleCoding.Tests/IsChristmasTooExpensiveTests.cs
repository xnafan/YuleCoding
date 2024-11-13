using YuleCoding.Code;
using YuleCoding.Code.HelperClasses;

namespace YuleCoding.Tests;

[TestFixture]
internal class IsChristmasTooExpensiveTests
{

    [Test]
    public void IsChristmasTooExpensive_GiftsCostLessThanMaxBudget_ReturnsFalse()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        var gifts = new List<Gift>
        {
            new Gift { Content = "Toy", Price = 10 },
            new Gift { Content = "Book", Price = 20 },
            new Gift { Content = "Socks", Price = 5 }
        };
        int maxBudget = 50;

        // Act
        bool result = yuleMachine.IsChristmasTooExpensive(gifts, maxBudget);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsChristmasTooExpensive_GiftsCostEqualToMaxBudget_ReturnsFalse()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        var gifts = new List<Gift>
        {
            new Gift { Content = "Toy", Price = 10 },
            new Gift { Content = "Book", Price = 20 },
            new Gift { Content = "Socks", Price = 5 }
        };
        int maxBudget = 35;

        // Act
        bool result = yuleMachine.IsChristmasTooExpensive(gifts, maxBudget);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsChristmasTooExpensive_GiftsCostMoreThanMaxBudget_ReturnsTrue()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        var gifts = new List<Gift>
        {
            new Gift { Content = "Toy", Price = 10 },
            new Gift { Content = "Book", Price = 20 },
            new Gift { Content = "Socks", Price = 5 }
        };
        int maxBudget = 30;

        // Act
        bool result = yuleMachine.IsChristmasTooExpensive(gifts, maxBudget);

        // Assert
        Assert.That(result, Is.True);
    }
}
