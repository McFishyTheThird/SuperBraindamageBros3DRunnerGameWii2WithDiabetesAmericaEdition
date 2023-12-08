namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Average_Man : Player
{
    public Fist starterWeapon = new();
    public Average_Man()
    {
        name = "Average-Man";
        maxHealth = 150;
        health = maxHealth;
        //affects how much heavyness on weapons affect speed
        strength = 10;
        speed = 10;
        critChance = 10;
        critMultiplier = 1.5f;
        dodge = 10;
        damageMultiplier = 1f;
        currentWeapon = starterWeapon;
        Ability ability = new();
    }
}
