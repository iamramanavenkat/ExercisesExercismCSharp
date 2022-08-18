using System;

public class Player
{
    Random rand = new Random();
    public int RollDie()
    {
        return rand.Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        return rand.NextDouble() * 100;
    }
}
