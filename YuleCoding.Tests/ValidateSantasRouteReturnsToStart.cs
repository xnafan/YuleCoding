﻿namespace YuleCoding.Tests;
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
    [Test]
    public void ValidateSantasRouteReturnsToStart_EmptyRoute_ReturnsTrue()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        // Act
        bool result = yuleMachine.ValidateSantasRouteReturnsToStart("");
        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void InvalidCharacterInRoute_ThrowsArgumentException()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        // Act & Assert
        Assert.Throws<ArgumentException>(() => yuleMachine.ValidateSantasRouteReturnsToStart("NESWZ"));
    }
}
