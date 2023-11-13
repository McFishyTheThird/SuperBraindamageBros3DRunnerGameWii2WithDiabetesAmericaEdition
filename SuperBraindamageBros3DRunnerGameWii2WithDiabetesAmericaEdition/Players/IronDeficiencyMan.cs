namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class IronDeficiencyMan : Player
{
    public IronDeficiencyMan()
    {
        name = "Iron Deficency-Man";
        maxHealth = 50;
        health = 50;
        //affects how much heavyness on weapons affect speed
        strength = 5;
        speed = 10;
        critChance = 75;
        critMultiplier = 5;
        dodge = 0;
        damage = .5f;
        Ability ability = new();
    }
}
