namespace YuleCoding.Code.HelperClasses;
public class Gift : IEquatable<Gift>
{
    public enum WrappingPaperType
    {
        Reindeer, Elves, Snow, NorthPole
    }
    public int Price { get; set; }
    public string Content { get; set; }
    public WrappingPaperType WrappingPaper { get; set; }
    public string From { get; set; }
    public string To { get; set; }

    public override string ToString()
    {
        return $"GIFT - From: {From}, To: {To}, Content: {Content}, Price: {Price}, WrappingPaper: {WrappingPaper}";
    }

    public bool Equals(Gift? other)
    {
        if (!(other is Gift) || other is null) return false;
        return Price == other.Price && Content == other.Content && WrappingPaper == other.WrappingPaper && From == other.From && To == other.To;
    }
}
