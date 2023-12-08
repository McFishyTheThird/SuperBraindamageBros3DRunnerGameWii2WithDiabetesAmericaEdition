namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Cancer_Growth : TemporaryDamageBuff
{
    public Cancer_Growth()
    {
        roundAmount = 0;
        roundAmountMax = 0;
        coolDown = 0;
        coolDownMax = 0;
        name = "Cancer Growth";
        automatic = true;
    }

    public override void UsingAbility(Weapon currentWeapon)
    {
        currentWeapon.minDamage++;
        currentWeapon.maxDamage++;
    }

    public override void AbilityEnd(Weapon currentWeapon)
    {
        currentWeapon.minDamage -= 1;
        currentWeapon.maxDamage -= 1;
    }
}
