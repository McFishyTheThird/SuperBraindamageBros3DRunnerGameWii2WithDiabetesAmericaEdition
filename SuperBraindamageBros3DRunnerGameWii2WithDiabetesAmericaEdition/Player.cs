namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Player : Characters
{
    public Weapon currentWeapon = new();
    public Inventory inventory = new();
    //how many percent damage weapons do
    public float damage;
    public Ability ability = new();
    //affects how much heavyness on weapons affect speed
    public int strength;

    public void Attack(List<Enemy> enemies, Random generator, Player playerCharacter,bool  isLevelChanging)
    {
        Console.Clear();
        Console.WriteLine("Choose which enemy to attack");
        for(int i = 0; i < enemies.Count; i++)
        {
            Console.WriteLine($"{i+1}. {enemies[i].name}");
        }
        int attackChoice;
        while (!int.TryParse(Console.ReadLine(), out attackChoice))
        {       
            Console.Write("You didn't provide a number you stupid dumb fuck, please try again:");
        }
        if(attackChoice > enemies.Count)
        {
            Console.WriteLine("You fucking moron...You attack a nonexistent enemy and obviously miss");
            Console.WriteLine("Guess your dumber than i thought");
            Console.ReadLine();
        }
        else
        {    
            for(int i = 0; i < enemies.Count; i++)
            {
                if(attackChoice == i+1)
                {
                    currentWeapon.AttackDamage(currentWeapon);
                    int willDodge = generator.Next(0, 100);
                    if(willDodge <= enemies[i].dodge)
                    {
                        Console.WriteLine($"The {enemies[i].name} managed to escape your attack unscathed");
                    }
                    else
                    {
                        int willCrit = generator.Next(0,100);
                        if(willCrit <= playerCharacter.critChance)
                        {
                            playerCharacter.damage = currentWeapon.damage*playerCharacter.critMultiplier;
                            Console.WriteLine("You score a crit");
                        }
                        if(playerCharacter.damage < 1)
                        {
                            playerCharacter.damage = 1;
                        }

                        enemies[i].health -= (int)playerCharacter.damage;
                        playerCharacter.damage = currentWeapon.damage;
                        Console.WriteLine($"You managed to hit the {enemies[i].name}");
                    }
                    if(enemies[i].health < 0)
                    {
                        enemies[i].health = 0;
                    }
                    Console.WriteLine($"{enemies[i].name}s Health: {enemies[i].health}");
                    Console.ReadLine();
                    if(enemies[i].health == 0)
                    {
                        enemies.Remove(enemies[i]);
                    }

                }
            }
        }
    }
}
