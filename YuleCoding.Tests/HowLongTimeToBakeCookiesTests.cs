namespace YuleCoding.Tests;
[TestFixture]
internal class HowLongTimeToBakeCookiesTests
{
    [Test]
    public void HowLongTimeToBakeCookies_WhenGivenCookies_ShouldReturnTimeToBake()
    {
        // Arrange
        var yuleMachine = new YuleMachine();
        var cookieRecipes = new List<Recipe>
        {
            new Recipe { Name = "Gingerbread", TimeToMake = 35 },
            new Recipe { Name = "Sugar", TimeToMake = 30 },
            new Recipe { Name = "Chocolate Chip", TimeToMake = 40 }
        };
        // Act
        var result = yuleMachine.HowLongTimeToBakeCookies(cookieRecipes);

        // Assert
        var expectedTime = cookieRecipes.Sum(recipe => recipe.TimeToMake);
        expectedTime += (cookieRecipes.Count-1) * 10; // 10 minutes to get the kitchen ready for the next recipe
        expectedTime += 30; // 30 minutes to clean up the kitchen when we're done

        Assert.That(result, Is.EqualTo(expectedTime));
    }
}
