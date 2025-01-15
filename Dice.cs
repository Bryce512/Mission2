namespace Mission2;

public class Dice
{
    //CREATE OBJECTS/VARIABLES
    Random _rnd = new Random();
    int roll1;
    int roll2;
    int sum;
    int[] results = new int[11];
    int numRolls;
    
    //CONSTRUCTOR
    public Dice(int num)
    {
        numRolls = num;
    }
    
    //ROLL DICE()
    public int[] RollDice()
    {
        for (int i = 0; i < numRolls; i++)
        {
            roll1 = _rnd.Next(1, 7);
            roll2 = _rnd.Next(1, 7);
            sum = roll1 + roll2;
            results[sum - 2] += 1;
        }
        return results;
    }
}