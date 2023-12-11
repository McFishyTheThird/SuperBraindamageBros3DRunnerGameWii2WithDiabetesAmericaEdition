namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Dying : TemporaryDamageBuff
{
    public Dying()
    {
        roundAmount = 0;
        roundAmountMax = 0;
        coolDown = 0;
        coolDownMax = 2;
        name = "Dying";
        automatic = true;
    }

    public override void UsingAbility(Weapon currentWeapon, Player playerCharacter)
    {
        playerCharacter.critChance += 25;
        playerCharacter.health -= 5;
    }

    public override void AbilityEnd(Weapon currentWeapon, Player playerCharacter)
    {
        playerCharacter.critChance -= 25;
    }
}
