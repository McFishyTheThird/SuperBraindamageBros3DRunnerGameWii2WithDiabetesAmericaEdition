namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Asthma_Boy : Player
{
    public Asthma_Boy()
    {
        name = "Asthma-Boy";
        maxHealth = 75;
        health = 75;
        //affects how much heavyness on weapons affect speed
        strength = 10;
        speed = 5;
        critChance = 25;
        critMultiplier = 2;
        dodge = 10;
        damage = 1f;
        Ability ability = new();
    }
}