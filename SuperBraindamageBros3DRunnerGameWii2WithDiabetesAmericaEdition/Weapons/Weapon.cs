namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Weapon
{
    public float minDamage;

    public float maxDamage;

    public int weight;

    public float damage;
    Random generator = new();

    public virtual float AttackDamage(Weapon currentWeapon)
    {
        return damage = generator.Next((int)currentWeapon.minDamage, (int)currentWeapon.maxDamage);
    } 
}
