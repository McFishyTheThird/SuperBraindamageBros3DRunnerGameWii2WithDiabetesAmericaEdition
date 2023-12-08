namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Characters
{
    public string name;
    public int maxHealth;
    public int health;
    public int speed;
    public int critChance;
    public float critMultiplier;
    public int dodge;

    public virtual void Attack(List<Enemy> enemies, Random generator, Player playerCharacter, int enemyNumber, bool isLevelChanging)
    {
        enemies[0].health -= (int)playerCharacter.currentWeapon.damage;
    }
}
