// Madison Diefenbach
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate? ");

        int rolls = int.Parse(Console.ReadLine());

        DiceRoller roller = new DiceRoller();
        int[] results = roller.RollDice(rolls);

        Console.WriteLine();
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {rolls}. ");
        Console.WriteLine();

        for (int sum = 2; sum<=12; sum++) // loops through each possible number
        {
            int count = results[sum];
            double percentage = (count / (double)rolls) * 100;

            int stars = (int)Math.Round(percentage, MidpointRounding.AwayFromZero);

            Console.Write($"{sum}: ");
            Console.WriteLine(new string('*', stars));
        }
        Console.WriteLine();
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}