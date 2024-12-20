﻿namespace YuleCoding.Tests;

[TestFixture]
public class IsItChristmasEveTests
{
    [Test]
    public void IsItChristmasDay_Before24th_ReturnsFalse()
    {
        // Arrange
        YuleMachine _yuleMachine = new();

        // Act
        bool isItChristmas = _yuleMachine.IsItChristmasEve(23);

        // Assert
        Assert.IsFalse(isItChristmas, "It isn't Christmas until the 24th!");
    }

    [Test]
    public void IsItChristmasDay_After24th_ReturnsFalse()
    {
        // Arrange
        YuleMachine _yuleMachine = new();

        // Act
        bool isItChristmas = _yuleMachine.IsItChristmasEve(25);

        // Assert
        Assert.IsFalse(isItChristmas, "It isn't Christmas after the 24th!");
    }

    [Test]
    public void IsItChristmasDay_On24th_ReturnsTrue()
    {
        // Arrange
        YuleMachine _yuleMachine = new();

        // Act
        bool isItChristmas = _yuleMachine.IsItChristmasEve(24);

        // Assert
        Assert.IsTrue(isItChristmas, "It is the 24th, so it should be Christmas!");
    }
}