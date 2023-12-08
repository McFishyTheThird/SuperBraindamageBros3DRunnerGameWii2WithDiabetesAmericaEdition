namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Player : Characters
{
    public Weapon currentWeapon = new();
    public Inventory inventory = new();
    //how many percent damage weapons do
    public float damageMultiplier;
    public Ability ability;
    //affects how much heavyness on weapons affect speed
    public int strength;

    public override void Attack(List<Enemy> enemies, Random generator, Player playerCharacter, int enemyNumber, bool isLevelChanging)
    {
        Console.Clear();
        Console.WriteLine("Choose which enemy to attack");
        for(int i = 0; i < enemies.Count; i++)
        {
            Console.WriteLine($"{i+1}. {enemies[i].name}");
            Console.WriteLine($"{i+1}: {enemies[i].health} Health");
            Console.WriteLine($"{i+1}: {enemies[i].minDamage}-{enemies[i].maxDamage} Damage");
            Console.WriteLine($"{i+1}: {enemies[i].critChance} Crit Chance");
            Console.WriteLine("");
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
                    for(int a = 0; a < currentWeapon.attackAmount; a++)
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
                                currentWeapon.damage = currentWeapon.damage*(int)playerCharacter.critMultiplier;
                                Console.WriteLine("You score a crit");
                            }
                            if(currentWeapon.damage < 1)
                            {
                                currentWeapon.damage = 1;
                            }

                            enemies[i].health -= (int)currentWeapon.damage;
                            Console.WriteLine($"You managed to hit the {enemies[i].name}");
                        }
                        if(enemies[i].health < 0)
                        {
                            enemies[i].health = 0;
                        }
                        Console.WriteLine($"{enemies[i].name}s Health: {enemies[i].health}");
                        if(enemies[i].health == 0)
                        {
                            enemies.Remove(enemies[i]);
                            currentWeapon.attackAmount = 0;
                        }
                        if(ability.coolDown > 0)
                        {
                            ability.coolDown--;
                        }
                        if(ability.coolDown == 0)
                        {
                            if(ability.automatic == false)
                            {
                                Console.WriteLine($"do you want to use your weapons ability {currentWeapon.ability.name}(y/n)");
                                string abilityUsage = Console.ReadLine().ToLower();
                                if(abilityUsage == "y" || abilityUsage == "yes")
                                {
                                    currentWeapon.ability.UsingAbility(currentWeapon);
                                }
                                else
                                {

                                }
                            }
                            else if(ability.automatic == true)
                            {
                                currentWeapon.ability.UsingAbility(currentWeapon); 
                            }
                        }
                    }
                    if(ability is TemporaryDamageBuff)
                    {
                        TemporaryDamageBuff buff = (TemporaryDamageBuff) ability;
                        if(buff.roundAmount > 0)
                        {
                            buff.roundAmount--;
                        }
                        if(buff.roundAmount == 0)
                        {
                            currentWeapon.ability.AbilityEnd(currentWeapon);
                        }
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
