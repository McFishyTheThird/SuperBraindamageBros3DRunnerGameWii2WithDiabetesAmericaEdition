namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Enemy : Characters
{
    public int minDamage;
    public int maxDamage;
    public int damage;
    public override void Attack(List<Enemy> enemies, Random generator, Player playerCharacter, int enemyNumber, bool isLevelChanging)
    {
        int willDodge = generator.Next(0, 100);
        if(willDodge <= playerCharacter.dodge)
        {
            Console.WriteLine("You dodged the attack");
        }
        else
        {
            enemies[enemyNumber].AttackDamage(enemies, enemyNumber, generator);
            int willCrit = generator.Next(0,100);
            if(willCrit <= enemies[enemyNumber].critChance)
            {
                damage = damage*(int)enemies[enemyNumber].critMultiplier;
                Console.WriteLine("You score a crit");
            }
            if(playerCharacter.damageMultiplier < 1)
            {
                playerCharacter.damageMultiplier = 1;
            }

            playerCharacter.health -= enemies[enemyNumber].damage;
            Console.WriteLine($"You got hit by the {enemies[enemyNumber].name}");
        }

    }
    public virtual float AttackDamage(List<Enemy>enemies, int enemyNumber, Random generator)
    {
        return damage = generator.Next(enemies[enemyNumber].minDamage, enemies[enemyNumber].maxDamage);
    } 
}
