namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Cancer_Crusader : Player
{
    public Cancer_Crusader()
    {
        name = "Cancer Crusader";
        maxHealth = 120;
        health = 120;
        //affects how much heavyness on weapons affect speed
        strength = 15;
        speed = 5;
        critChance = 10;
        critMultiplier = 5;
        dodge = 0;
        damage = 1.5f;
        Ability ability = new();
    }
}
