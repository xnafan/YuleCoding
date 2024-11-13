namespace YuleCoding.Code
{
    internal class Program
    {
        static void Main(string[] args)
        {

            YuleMachine yuleMachine = new();
            Console.WriteLine(yuleMachine.CreateChristmasTree(10));
            Console.WriteLine(  );
            Console.WriteLine(yuleMachine.CreateChristmasTree(3));
            Console.WriteLine();
            Console.WriteLine(yuleMachine.CreateAsciiSnow(25,15, 3));

        }
    }
}
