// See https://aka.ms/new-console-template for more information

using Mission2;

int numRolls;
int[] results;


// INITIALIZE PROMPT
Console.WriteLine("Welcome to the Dice Throwing Simulator!");
Console.Write("How many rolls would you like to simulate? ");
numRolls = Int32.Parse(Console.ReadLine());

Dice dice1 = new Dice(numRolls);
results = dice1.RollDice();


//INITIALIZE PRINT RESULTS
Console.WriteLine();
Console.WriteLine("DICE SIMULATION RESULTS");
Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
Console.Write("Total number of rolls = ");
Console.WriteLine(numRolls);

results = CleanArray();

//DISPLAY RESULTS
for (int i = 0; i < 11; i++)
{
    Console.Write((i + 2)+ ": ");
    for (int j = 0; j < results[i]; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//CLEAN UP RESULTS
 int[] CleanArray()
{
    for (int i = 0; i < results.Length; i++)
    {
        int percent = (int)Math.Round(((double)results[i]/numRolls)*100);
        results[i] = percent;
    }
    return results;
}