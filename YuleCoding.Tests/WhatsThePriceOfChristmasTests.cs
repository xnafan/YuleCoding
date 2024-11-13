using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuleCoding.Code;
using YuleCoding.Code.HelperClasses;

namespace YuleCoding.Tests;

[TestFixture]
internal class WhatsThePriceOfChristmasTests
{

    [Test]
    public void WhatsThePriceOfChristmas_EmptyList_ReturnsZero()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        var gifts = new List<Gift>();

        // Act
        int result = yuleMachine.WhatsThePriceOfChristmas(gifts);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void WhatsThePriceOfChristmas_SingleGift_ReturnsPriceOfGift()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        var gifts = new List<Gift> { new Gift { Price = 10 } };

        // Act
        int result = yuleMachine.WhatsThePriceOfChristmas(gifts);

        // Assert
        Assert.That(result, Is.EqualTo(10));
    }

    [Test]
    public void WhatsThePriceOfChristmas_MultipleGifts_ReturnsSumOfPrices()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        var gifts = new List<Gift>
        {
            new Gift { Price = 10 },
            new Gift { Price = 20 },
            new Gift { Price = 30 }
        };

        // Act
        int result = yuleMachine.WhatsThePriceOfChristmas(gifts);

        // Assert
        Assert.That(result, Is.EqualTo(60));
    }
}
