
using System.Text;

namespace YuleCoding.Tests;
[TestFixture]
internal class CreateChristmasTreeTests
{
    [Test]
    public void CreateChristmasTree_WithHeightOf1_ReturnsTree()
    {
        // Arrange
        YuleMachine yuleMachine = new();

        // Act
        string result = yuleMachine.CreateChristmasTree(1);

        // Assert
        string expected = GetExpectedChristmasTree(1);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CreateChristmasTree_WithHeightOf5_ReturnsTree()
    {
        // Arrange
        YuleMachine yuleMachine = new();
        // Act
        string result = yuleMachine.CreateChristmasTree(5);
        // Assert
        string expected = GetExpectedChristmasTree(5);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CreateChristmasTree_WithHeightOfZero_ThrowsArgumentException()
    {
        // Arrange
        YuleMachine yuleMachine = new();
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => yuleMachine.CreateChristmasTree(0));
    }

    private static string GetExpectedChristmasTree(int height)
    {
        StringBuilder christmasTree = new();
        for (int i = 1; i <= height; i++)
        {
            christmasTree.Append(new string(' ', height - i));
            christmasTree.Append(new string('*', i * 2 - 1));
            christmasTree.Append('\n');
        }
        christmasTree.Append(new string(' ', height - 1));
        christmasTree.Append("|\n");
        return christmasTree.ToString();

    }
}
