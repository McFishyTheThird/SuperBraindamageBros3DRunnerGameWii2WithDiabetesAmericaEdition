namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Asthma_Boy : Player
{
    public Nebulizer starterWeapon = new();
    public Asthma_Boy()
    {
        name = "Asthma-Boy";
        maxHealth = 125;
        health = maxHealth;
        //affects how much heavyness on weapons affect speed
        strength = 10;
        speed = 5;
        critChance = 25;
        critMultiplier = 2;
        dodge = 10;
        damageMultiplier = 1f;
        currentWeapon = starterWeapon;
        Ability ability = new();
    }
}