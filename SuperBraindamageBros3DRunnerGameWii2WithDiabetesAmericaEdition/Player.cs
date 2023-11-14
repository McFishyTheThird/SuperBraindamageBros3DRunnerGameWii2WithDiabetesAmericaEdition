namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Player : Characters
{
    public Weapon currentWeapon = new();
    public Inventory inventory = new();
    //how many percent damage weapons do
    public float damage;
    public Ability ability = new();

    public void Attack(Random generator, Player playerCharacter)
    {
        currentWeapon.AttackDamage(currentWeapon);
        int crit = generator.Next(0, 100);
        if(crit <= playerCharacter.critChance)
        {
            currentWeapon.damage = damage * playerCharacter.critMultiplier;
        }
    }
}
