namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Cancer_Crusader : Player
{
    public Stage_4 starterWeapon = new();
    public Cancer_Crusader()
    {
        name = "Cancer Crusader";
        maxHealth = 170;
        health = maxHealth;
        //affects how much heavyness on weapons affect speed
        strength = 15;
        speed = 5;
        critChance = 10;
        critMultiplier = 5;
        dodge = 0;
        damageMultiplier = 1.5f;
        currentWeapon = starterWeapon;
        Ability ability = new();
    }
}
