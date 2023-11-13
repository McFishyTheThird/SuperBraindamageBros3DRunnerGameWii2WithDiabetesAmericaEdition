namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Average_Man : Player
{
    public Average_Man()
    {
        name = "Average-Man";
        maxHealth = 100;
        health = 100;
        //affects how much heavyness on weapons affect speed
        strength = 10;
        speed = 10;
        critChance = 10;
        critMultiplier = 1.5f;
        dodge = 10;
        damage = 1f;
        Ability ability = new();
    }
}
