namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Ability
{
    public int coolDown;
    public int coolDownMax;
    public string name;
    public bool automatic;
    public virtual void UsingAbility(Weapon currentWeapon)
    {
        
    }
    public virtual void AbilityEnd(Weapon currentWeapon)
    {

    }
}
