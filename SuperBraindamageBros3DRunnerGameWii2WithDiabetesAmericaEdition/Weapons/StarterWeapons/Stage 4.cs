namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Stage_4 : Weapon
{   
    public Cancer_Growth starterAbility = new();
    public Stage_4()
    {
        name = "Stage 4 Braincancer";
        minDamage = 1;

        maxDamage = 1;

        weight = 0;

        attackAmount = 5;
        
        ability = starterAbility;
    }
}
