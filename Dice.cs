namespace Mission2;

public class Dice
{
    Random rnd = new Random();
    int num;
    public int RollDice()
    {
        num = rnd.Next(1, 7);
        return num;
    }
}