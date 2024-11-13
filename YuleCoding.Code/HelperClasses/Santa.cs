namespace YuleCoding.Code.HelperClasses;
public static class Santa
{
    public static IEnumerable<Gift> GetGifts()
    {
        return new List<Gift>()
    {
        new Gift(){ Content = "Perfume", From = "Anna", To = "Bob", Price = 300, WrappingPaper = Gift.WrappingPaperType.Reindeer },
        new Gift(){ Content = "Book", From = "Bob", To = "Cathy", Price = 100, WrappingPaper = Gift.WrappingPaperType.Elves },
        new Gift(){ Content = "Scarf", From = "Cathy", To = "Derek", Price = 50, WrappingPaper = Gift.WrappingPaperType.Snow },
        new Gift(){ Content = "Chess Set", From = "Derek", To = "Anna", Price = 150, WrappingPaper = Gift.WrappingPaperType.NorthPole },
        new Gift(){ Content = "Teddy Bear", From = "Anna", To = "Edith", Price = 80, WrappingPaper = Gift.WrappingPaperType.Elves },
        new Gift(){ Content = "Toy Train", From = "Bob", To = "Edith", Price = 120, WrappingPaper = Gift.WrappingPaperType.Snow },
        new Gift(){ Content = "Coloring Book", From = "Cathy", To = "Edith", Price = 30, WrappingPaper = Gift.WrappingPaperType.Reindeer },
        new Gift(){ Content = "Dollhouse", From = "Derek", To = "Edith", Price = 200, WrappingPaper = Gift.WrappingPaperType.NorthPole },
        new Gift(){ Content = "Socks", From = "Edith", To = "Anna", Price = 20, WrappingPaper = Gift.WrappingPaperType.Snow },
        new Gift(){ Content = "Hat", From = "Edith", To = "Bob", Price = 25, WrappingPaper = Gift.WrappingPaperType.Elves },
        new Gift(){ Content = "Notebook", From = "Anna", To = "Cathy", Price = 40, WrappingPaper = Gift.WrappingPaperType.Reindeer },
        new Gift(){ Content = "Puzzle", From = "Bob", To = "Derek", Price = 60, WrappingPaper = Gift.WrappingPaperType.Snow },
        new Gift(){ Content = "Art Supplies", From = "Cathy", To = "Anna", Price = 90, WrappingPaper = Gift.WrappingPaperType.NorthPole },
        new Gift(){ Content = "Keychain", From = "Derek", To = "Bob", Price = 15, WrappingPaper = Gift.WrappingPaperType.Elves },
        new Gift(){ Content = "Board Game", From = "Anna", To = "Derek", Price = 120, WrappingPaper = Gift.WrappingPaperType.Snow },
        new Gift(){ Content = "Stuffed Animal", From = "Bob", To = "Edith", Price = 70, WrappingPaper = Gift.WrappingPaperType.NorthPole },
        new Gift(){ Content = "Crayons", From = "Cathy", To = "Edith", Price = 20, WrappingPaper = Gift.WrappingPaperType.Reindeer },
        new Gift(){ Content = "Picture Book", From = "Derek", To = "Edith", Price = 45, WrappingPaper = Gift.WrappingPaperType.Elves },
        new Gift(){ Content = "Sweater", From = "Edith", To = "Cathy", Price = 50, WrappingPaper = Gift.WrappingPaperType.Snow },
        new Gift(){ Content = "Mittens", From = "Edith", To = "Derek", Price = 25, WrappingPaper = Gift.WrappingPaperType.Reindeer },
        new Gift(){ Content = "Mug", From = "Anna", To = "Bob", Price = 15, WrappingPaper = Gift.WrappingPaperType.Elves },
        new Gift(){ Content = "Chocolate", From = "Bob", To = "Anna", Price = 25, WrappingPaper = Gift.WrappingPaperType.NorthPole },
        new Gift(){ Content = "Toy Car", From = "Cathy", To = "Edith", Price = 50, WrappingPaper = Gift.WrappingPaperType.Snow },
        new Gift(){ Content = "Storybook", From = "Derek", To = "Edith", Price = 35, WrappingPaper = Gift.WrappingPaperType.Elves }
    };
    }
}