namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Characters
{
    public string name;
    public int maxHealth;
    public int health;
    //affects how much heavyness on weapons affect speed
    public int strength;
    public int speed;
    public int critChance;
    public float critMultiplier;
    public int dodge;
    public Characters enemyCharacter = new();
    public void Attack()
    {

    }
}
