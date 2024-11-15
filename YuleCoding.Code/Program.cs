namespace YuleCoding.Code;
internal class Program
{
    static void Main(string[] args)
    {

        YuleMachineSolved yuleMachine = new();

        // Christmas Countdown
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor= ConsoleColor.White;
        for (int dayNumber = 0; dayNumber < 31; dayNumber++)
        {
            Console.WriteLine(yuleMachine.ChristmasCounting(dayNumber));
        }
        Console.WriteLine();


        // Christmas Tree
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(yuleMachine.CreateChristmasTree(10));
        Console.WriteLine();

        //smaller tree
        Console.WriteLine(yuleMachine.CreateChristmasTree(3));
        Console.WriteLine();

        //ASCII snow
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor= ConsoleColor.White;
        Console.WriteLine(yuleMachine.CreateAsciiSnow(25,15, 3));

    }
}
