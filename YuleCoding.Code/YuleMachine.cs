using YuleCoding.Code.HelperClasses;

namespace YuleCoding.Code;
public class YuleMachine
{
    public bool IsItChristmasDay(int dayOfDecember)
    {
        return dayOfDecember == 24;
        throw new NotImplementedException();
    }
    public string ChristmasGreeting(string nameToGreet)
    {
        return "Merry Christmas, " + nameToGreet;
    }
    public string IsItChristmasYet(int dayOfDecember)
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
    public int WhatsThePriceOfChristmas(IEnumerable<Gift> gifts)
    {
        return gifts.Sum(gift => gift.Price);
    }
    public bool IsChristmasTooExpensive(IEnumerable<Gift> gifts, int maxBudget)
    {
        return WhatsThePriceOfChristmas(gifts) > maxBudget;
    }
    public int HowFarHaveTheReinDeerTravelled(IEnumerable<Mood> distances)
    {
        return distances.Cast<int>().Sum();
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
    public IEnumerable<Gift> SortGiftsByToAndFrom(IEnumerable<Gift> giftsToSort)
    {
      return giftsToSort.OrderBy(gift => gift.To).ThenBy(gift => gift.From);
    }
    public int DaysTillNextChristmas()
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
}