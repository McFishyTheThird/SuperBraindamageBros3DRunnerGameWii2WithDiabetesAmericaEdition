namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Weapon : Item
{
    public float minDamage;

    public float maxDamage;

    public int weight;

    public int damage;
    Random generator = new();

    public virtual float AttackDamage(Weapon currentWeapon)
    {
        return damage = generator.Next((int)currentWeapon.minDamage, (int)currentWeapon.maxDamage);
    } 
}
