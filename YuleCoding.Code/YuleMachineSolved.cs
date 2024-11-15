using System.Text;
using YuleCoding.Code.HelperClasses;
namespace YuleCoding.Code;
public class YuleMachineSolved
{
    public bool IsItChristmasEve(int dayOfDecember)
    {
        return dayOfDecember == 24;
    }
    public string ChristmasGreeting(string nameToGreet)
    {
        return "Merry Christmas, " + nameToGreet;
    }
    public string IsItChristmasEveYet(int dayOfDecember)
    {
        switch(dayOfDecember)
        {
            case < 23:
                return "Not yet!";
            case 24:
                return "Yes!";
            default:
                return "It's over!";
        }
    }
    public bool ChristmasPoemChecker(string poem)
    {
        return poem.Contains("christmas", StringComparison.OrdinalIgnoreCase)
            && poem.Contains("code", StringComparison.OrdinalIgnoreCase)
            && poem.Contains("snow", StringComparison.OrdinalIgnoreCase); 
    }
    public int HowManySantas(string stringWithSanta)
    {
        return stringWithSanta.Split(new[] { "Santa" }, StringSplitOptions.None).Length - 1;
    }
    public int WhosPositive(IEnumerable<int> numbers)
    {
        return numbers.Count(number => number > 0);
    }
    public string FestiveMaker(string text)
    {
        return text.Replace(" ", "🎄");
    }
    public string EvenFestiverMaker(string text)
    {
        return text.Replace("rain", "snow").Replace("sad", "jolly").Replace("bill", "gift");
    }
    public Dictionary<Person.NiceOrNaughty, List<Person>> NiceAndNaughtyLists(IEnumerable<Person> people)
    {
        Dictionary<Person.NiceOrNaughty, List<Person>> niceAndNaughtyLists = new();
        niceAndNaughtyLists.Add(Person.NiceOrNaughty.Nice, people.Where(person => person.NiceOrNaughtyStatus == Person.NiceOrNaughty.Nice).ToList());
        niceAndNaughtyLists.Add(Person.NiceOrNaughty.Naughty, people.Where(person => person.NiceOrNaughtyStatus == Person.NiceOrNaughty.Naughty).ToList());

        return niceAndNaughtyLists;
    }
    public int WhatsThePriceOfChristmas(IEnumerable<Gift> gifts)
    {
        return gifts.Sum(gift => gift.Price);
    }


    public bool IsChristmasTooExpensive(IEnumerable<Gift> gifts, int maxBudget)
    {
        return WhatsThePriceOfChristmas(gifts) > maxBudget;
    }
    public int CalculateSantaLetterNiceness(string letter)
    {
        letter = letter.ToLower();
        int score = 0;
        int numberOfPlease = letter.Split("please", StringSplitOptions.None).Length - 1;
        int numberOfThankYou = letter.Split("thank you", StringSplitOptions.None).Length - 1;

        score += numberOfPlease * 2;
        score += numberOfThankYou * 3;
        return score;

    }
    public int HowLongTimeToBakeCookies(IEnumerable<Recipe> recipes)
    {
        int timeToGetKitchenReadyForNextRecipe = (recipes.Count() - 1) * 10;
        int timeToCleanUpKitchen = 30;
        int timeToMakeCookies = recipes.Sum(recipe => recipe.TimeToMake);
        return timeToMakeCookies + timeToGetKitchenReadyForNextRecipe + timeToCleanUpKitchen;
    }
    public int HowFarHaveTheReinDeerTravelled(IEnumerable<Mood> distances)
    {
        return distances.Cast<int>().Sum();
    }
    public int CalculateAmountOfGiftWrappingPaperNecessary(int height, int width, int depth)
    {
        return 2 * (height * width + width * depth + depth * height);
    }
    public IEnumerable<Gift> SortGiftsByToAndFrom(IEnumerable<Gift> giftsToSort)
    {
      return giftsToSort.OrderBy(gift => gift.To).ThenBy(gift => gift.From);
    }
    public IEnumerable<string> SortSantasReindeer(IEnumerable<string> reindeer)
    {
        var orderedReindeer = reindeer.OrderBy(reindeer => reindeer).ToList();
        if(reindeer.Contains("Rudolph"))
        {
            orderedReindeer.Remove("Rudolph");
            orderedReindeer.Insert(0, "Rudolph");
        }
        return orderedReindeer;
    }
    public int DaysTillNextChristmasEve()
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        if (today.Month == 12 && today.Day == 24) { return 0; }
        int nextChristMasYear = today.Year;
        if (today.Month == 12 && today.Day > 24) { nextChristMasYear++; }
        DateOnly nextChristmasDate = new DateOnly(nextChristMasYear, 12, 24);
        return nextChristmasDate.DayNumber - today.DayNumber;
    }
    public bool ValidateSantasRouteReturnsToStart(IEnumerable<char>directions)
    {
        List<char> validDirections = new List<char>() { 'N', 'S', 'E', 'W' };
        if(directions.Any(character => !validDirections.Contains(character)))
        {
            throw new ArgumentException("Unrecognized direction (not, N,S,E,W) in directions");
        }
        bool equalNumberOfNorthAndSouth = directions.Count(direction => direction == 'N') == directions.Count(direction => direction == 'S');
        bool equalNumberOfEastAndWest = directions.Count(direction => direction == 'E') == directions.Count(direction => direction == 'W');

        return equalNumberOfEastAndWest && equalNumberOfNorthAndSouth;
    }
    public IEnumerable<string> DrawChristmasRaffleWinners(IEnumerable<string> participants, int numberOfWinners)
    {
        if (participants.Count() < 1) { throw new ArgumentException("Must be at least one participant!"); }
        if (numberOfWinners < 1) { throw new ArgumentException("Must be at least one winner!"); }
        if (participants.Count() < numberOfWinners) { throw new ArgumentException("Not enough participants for the number of winners!"); }

        List<string> winners = new();
        while (winners.Count < numberOfWinners)
        {
            string winner = participants.ElementAt(Random.Shared.Next(participants.Count()));
            if (!winners.Contains(winner))
            {
                winners.Add(winner);
            }
        }
        return winners;
    }


    public string ChristmasCounting(int digit)
    {
        if (digit < 1 || digit > 24) { return "BAH, Humbug!"; }
        bool divisibleByThree = (digit % 3 == 0);
        bool divisibleByFive = (digit % 5 == 0);
        if (divisibleByFive && divisibleByThree) { return "Happy Holidays!"; }
        if (!divisibleByFive && !divisibleByThree) { return digit.ToString(); }
        string returnValue = "";
        if (divisibleByThree) { returnValue += "Ho"; }
        if (divisibleByFive) { returnValue += "HoHo"; }
        return returnValue;
    }
    public Dictionary<string, string> CreateSecretSantaList(IEnumerable<string> participantNames)
    {
        if (participantNames.Count() < 2) { throw new ArgumentException("Must be at least two people in the list!"); }
        Dictionary<string, string> secretSantaPairs = new();
        List<string> participants = participantNames.ToList();
        string from, to;
        for (int i = 0; i < participantNames.Count()-1; i++)
        {
            from = participantNames.ElementAt(i);
            to = participantNames.ElementAt(i+1);
            secretSantaPairs[from] = to; 
        }
        from = participantNames.Last();
        to = participantNames.First();
        secretSantaPairs[from] = to;

        return secretSantaPairs;
    }
    public string CreateAsciiSnow(int width, int height, int distanceBetweenSnowFlakes)
    {
        if (width < 1 || height < 1) { throw new ArgumentException("Width and height must be at least 1"); }
        StringBuilder snow = new();
        for (int i = 0; i <= width * height; i++)
        {
            snow.Append(i % distanceBetweenSnowFlakes == 0 ? '*' : ' ');
            if (i > 0 &&i % width == 0){snow.AppendLine();}
        }
        return snow.ToString();
    }
    public string CreateChristmasTree(int height)
    {
        if (height < 1) { throw new ArgumentException("Height must be at least 1"); }
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