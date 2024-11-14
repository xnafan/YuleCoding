namespace YuleCoding.Code
{
    internal class Program
    {
        static void Main(string[] args)
        {

            YuleMachine yuleMachine = new();

            for (int dayNumber = 0; dayNumber < 31; dayNumber++)
            {
                Console.WriteLine(yuleMachine.ChristmasCounting(dayNumber));
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(yuleMachine.CreateChristmasTree(10));
            Console.WriteLine(  );
            Console.WriteLine(yuleMachine.CreateChristmasTree(3));
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine(yuleMachine.CreateAsciiSnow(25,15, 3));

        }
    }
}
