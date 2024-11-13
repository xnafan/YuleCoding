namespace YuleCoding.Tests;

[TestFixture]
internal class NiceAndNaughtyListsTests
{

    [Test]
    public void NiceAndNaughtyLists_ReturnsCorrectLists()
    {
        // Arrange
        var people = new List<Person>
        {
            new Person { Name = "Santa", NiceOrNaughtyStatus = Person.NiceOrNaughty.Nice },
            new Person { Name = "Grinch", NiceOrNaughtyStatus = Person.NiceOrNaughty.Naughty },
            new Person { Name = "Rudolph", NiceOrNaughtyStatus = Person.NiceOrNaughty.Nice },
            new Person { Name = "Scrooge", NiceOrNaughtyStatus = Person.NiceOrNaughty.Naughty },
            new Person { Name = "Frosty", NiceOrNaughtyStatus = Person.NiceOrNaughty.Nice }
        };
        var yuleMachine = new YuleMachine();
        // Act
        var result = yuleMachine.NiceAndNaughtyLists(people);
        var niceList = result[Person.NiceOrNaughty.Nice];
        var naughtyList = result[Person.NiceOrNaughty.Naughty];
        
        // Assert
        Assert.That(niceList.Count, Is.EqualTo(3));
        Assert.IsTrue(niceList.All(person => person.NiceOrNaughtyStatus == Person.NiceOrNaughty.Nice));
        
        Assert.That(result[Person.NiceOrNaughty.Naughty].Count, Is.EqualTo(2));
        Assert.IsTrue(naughtyList.All(person => person.NiceOrNaughtyStatus == Person.NiceOrNaughty.Naughty));
    }
}
