namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class SuperBrainDamageBros
{
    public int enemyNumber;
    public string enemyRoundChoice;
    Player playerCharacter = new();
    public int enemyAmount;
    public int levelNumber = 1;
    public string levelType = "normal";
    public bool isLevelChanging = true;
    public List<Enemy> enemies = new(); 
    public List<Enemy> currentPossibleEnemies = new(); 
    public void Game(Random generator)
    {
        while(playerCharacter.health > 1)
        {
            if(isLevelChanging == true)
            {
                if(levelNumber%2 == 0)
                {
                    enemyAmount = generator.Next(1,5);
                    levelType = "Normal";
                }
                else
                {
                    levelType = "Special";
                }
                for(int i = 0; i < enemyAmount; i++)
                {
                    int addThisEnemy;
                    addThisEnemy = generator.Next(currentPossibleEnemies.Count);
                    enemies.Add(currentPossibleEnemies[addThisEnemy]);
                }
                isLevelChanging = false;
            }
            if(levelNumber <= 13)
            {
                Console.WriteLine($"{playerCharacter.name}s Stats:");
                Console.WriteLine($"{playerCharacter.name}s Health:{playerCharacter.health}");
                Console.WriteLine($"{playerCharacter.name}s Damage:{playerCharacter.damage}");
                Console.WriteLine($"{playerCharacter.name}s Crit Chance:{playerCharacter.critChance}");
                Console.WriteLine($"{playerCharacter.name}s Dodge Chance:{playerCharacter.dodgeChance}");
                Console.WriteLine($"{playerCharacter.name}s Armor:{playerCharacter.armor}");
                Console.WriteLine("Hey there, Captain Indecisive! The clock's ticking, and so is my patience. Your move, or should I flip a coin for you?");
                Console.WriteLine("A:Attack B:Heal C:Look at enemy stats");
                string playerChoice = Console.ReadLine().ToLower();
                Console.Clear();
                if(playerChoice == "a" || playerChoice == "attack")
                {
                    playerCharacter.Attack(enemyCars, generator, playerCharacter, isLevelChanging);
                    if(enemyCars.Count == 0)
                    {
                        // levelType = "shop";
                        levelNumber++;
                        isLevelChanging = true;
                        playerCharacter.maxHealth += 10;
                        playerCharacter.health = playerCharacter.maxHealth;
                        playerCharacter.maxDamage += 10;
                        playerCharacter.damage = playerCharacter.maxDamage;
                        playerCharacter.armor += 1;
                        playerCharacter.critChance += .5f;
                        playerCharacter.normalDodgeChance += 1;
                        playerCharacter.dodgeChance = playerCharacter.normalDodgeChance;
                        if(levelNumber <= 13)
                        {
                            Console.WriteLine("FUCK!!! You defeated the cars. guess its time for a bigger challenge");
                        }
                    }
                    else
                    {
                        for(int i = 0; i < enemyCars.Count; i++)
                        {
                            enemyNumber = i;
                            enemyCars[i].Attack(generator, playerCharacter, enemyCars, enemyNumber);
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(playerChoice == "b")
                {
                    Console.WriteLine("Since you are a massive coward who is afraid to die you choose to heal a bit");
                    playerCharacter.Heal(playerCharacter, enemyNumber, enemyCars, generator);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(playerChoice == "c")
                {
                    for(int i = 0; i < enemyCars.Count; i++)
                    {
                        Console.WriteLine($"{enemyCars[i].name} Stats:");
                        Console.WriteLine($"{enemyCars[i].name} Health:{enemyCars[i].health}");
                        Console.WriteLine($"{enemyCars[i].name} Damage:{enemyCars[i].damage}");
                        Console.WriteLine($"{enemyCars[i].name} Crit Chance:{enemyCars[i].critChance}");
                        Console.WriteLine($"{enemyCars[i].name} Dodge Chance:{enemyCars[i].dodgeChance}");
                        Console.WriteLine($"{enemyCars[i].name} Armor:{enemyCars[i].armor}");
                        Console.WriteLine("");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Goddammit...i guess you win.");
                Console.ReadLine();
                playerCharacter.health = 0;
            }

            // Shopping(shop.shopInventory);
        }
        Console.WriteLine("HAH! You fucking loser");
        Console.ReadLine();
    }
    
}
