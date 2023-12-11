namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Ability
{
    public int coolDown;
    public int coolDownMax;
    public string name;
    public bool automatic;
    public virtual void UsingAbility(Weapon currentWeapon, Player playerCharacter)
    {
        
    }
    public virtual void AbilityEnd(Weapon currentWeapon, Player playerCharacter)
    {

    }
}
