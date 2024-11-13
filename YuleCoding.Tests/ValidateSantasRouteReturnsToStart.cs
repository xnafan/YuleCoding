using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuleCoding.Code;

namespace YuleCoding.Tests;
[TestFixture]
internal class ValidateSantasRouteReturnsToStart
{
    [Test]
    public void ValidateSantasRouteReturnsToStart_InvalidRoute_ReturnsFalse()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        bool result = yuleMachine.ValidateSantasRouteReturnsToStart("NESWWEN");

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void ValidateSantasRouteReturnsToStart_ValidRoute_ReturnsTrue()
    {
        // Arrange
        var yuleMachine = new YuleMachine();

        // Act
        bool result = yuleMachine.ValidateSantasRouteReturnsToStart("NESW");

        // Assert
        Assert.That(result, Is.True);
    }
}
