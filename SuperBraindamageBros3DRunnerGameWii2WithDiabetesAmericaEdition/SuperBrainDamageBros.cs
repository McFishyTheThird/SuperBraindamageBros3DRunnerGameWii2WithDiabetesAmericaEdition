﻿using System.Security.Cryptography.X509Certificates;

namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class SuperBrainDamageBros
{
    public int enemyNumber;
    public Shop shop = new();
    public string enemyRoundChoice;
    Player playerCharacter = new();
    public int enemyAmount;
    public int levelNumber = 1;
    public string levelType = "normal";
    public bool isLevelChanging = true;
    public List<Player> players = new(); 
    public List<Enemy> enemies = new(); 
    public List<Enemy> currentPossibleEnemies = new(); 
    public int finalLevelNumber = 20; 
    Random generator = new();
    public void Game()
    {
        ChoosePlayer();
        while(playerCharacter.health > 1)
        {
            Console.Clear();
            if(isLevelChanging == true && levelNumber <= finalLevelNumber)
            {
                PossibleEnemies();
                if(levelNumber%2 == 0)
                {
                    levelType = "Special";
                }
                else
                {
                    enemyAmount = generator.Next(1,3);
                    levelType = "Normal";
                }
                for(int i = 0; i < enemyAmount; i++)
                {
                    int addThisEnemy;
                    addThisEnemy = generator.Next(currentPossibleEnemies.Count);
                    enemies.Add(currentPossibleEnemies[addThisEnemy]);
                }
                isLevelChanging = false;
            }
            if(levelNumber <= finalLevelNumber && levelType == "Normal")
            {
                Console.WriteLine($"{playerCharacter.name}s Stats:");
                Console.WriteLine($"{playerCharacter.name}s Health:{playerCharacter.health}");
                Console.WriteLine($"{playerCharacter.name}s Crit Chance:{playerCharacter.critChance}");
                Console.WriteLine($"{playerCharacter.name}s Crit Multiplier:{playerCharacter.critMultiplier}");
                Console.WriteLine($"{playerCharacter.name}s Dodge Chance:{playerCharacter.dodge}");
                Console.WriteLine($"{playerCharacter.name}s Weapon:{playerCharacter.currentWeapon.name}");
                Console.WriteLine($"{playerCharacter.name}s Weapon Damage:{playerCharacter.currentWeapon.minDamage}-{playerCharacter.currentWeapon.maxDamage}");
                Console.WriteLine("Hey there, Captain Indecisive! The clock's ticking, and so is my patience. Your move, or should I flip a coin for you?");
                Console.WriteLine("A:Attack B: Heal");
                string playerChoice = Console.ReadLine().ToLower();
                Console.Clear();
                if(playerChoice == "a" || playerChoice == "attack")
                {
                    playerCharacter.Attack(enemies, generator, playerCharacter, enemyNumber, isLevelChanging);
                    if(enemies.Count == 0)
                    {
                        levelNumber++;
                        isLevelChanging = true;
                        Console.WriteLine($"Level: {levelNumber}");
                    }
                    else
                    {
                        for(int i = 0; i < enemies.Count; i++)
                        {
                            enemyNumber = i;
                            enemies[i].Attack(enemies, generator, playerCharacter, enemyNumber, isLevelChanging);
                        }
                    }
                    Console.ReadLine();
                }
                if(playerChoice == "b" || playerChoice == "heal")
                {
                    for(int i = 0; i < enemies.Count; i++)
                    {
                        enemyNumber = i;
                        enemies[i].Attack(enemies, generator, playerCharacter, enemyNumber, isLevelChanging);
                        playerCharacter.Heal(playerCharacter);
                    }
                    Console.ReadLine();
                }
                if(playerCharacter.health > playerCharacter.maxHealth)
                {
                    if(playerCharacter.health-((playerCharacter.health-playerCharacter.maxHealth)/2) > playerCharacter.maxHealth)
                    {
                        playerCharacter.health -= (playerCharacter.health-playerCharacter.maxHealth)/2;
                    }
                    else if(playerCharacter.health-((playerCharacter.health-playerCharacter.maxHealth)/2) < playerCharacter.maxHealth)
                    {
                        playerCharacter.health = playerCharacter.maxHealth;
                    }
                }
            }
            else if(levelNumber <= finalLevelNumber && levelType == "Special")
            {
                Console.WriteLine($"Level {levelNumber}: Shop");
                shop.Shopping(generator, playerCharacter);
                isLevelChanging = true;
                levelNumber++;
            }
            else if(playerCharacter.health == 0)
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
    
    public void ChoosePlayer()
    {
        bool hasChosen = false;
        Asthma_Boy asthmaBoy = new();
        Average_Man averageMan = new();
        Cancer_Crusader cancerCrusader = new();
        IronDeficiencyMan ironDeficiencyMan = new();
        players.AddRange(new List<Player> {asthmaBoy, averageMan, cancerCrusader, ironDeficiencyMan});
        while(hasChosen == false)
        {
            for(int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"{i+1}. {players[i].name}");
            }
            Console.WriteLine("write the number of the character you want to play as");
            int playerChoice;
            while (!int.TryParse(Console.ReadLine(), out playerChoice))
            {       
                Console.Write("You didn't provide a number you stupid dumb fuck, please try again:");
            }
            playerCharacter = players[playerChoice-1];
            Console.WriteLine($"You are {playerCharacter.name}");
            Console.WriteLine($"{playerCharacter.name}s Stats:");
            Console.WriteLine($"{playerCharacter.name}s Health:{playerCharacter.health}");
            Console.WriteLine($"{playerCharacter.name}s Crit Chance:{playerCharacter.critChance}");
            Console.WriteLine($"{playerCharacter.name}s Crit Multiplier:{playerCharacter.critMultiplier}");
            Console.WriteLine($"{playerCharacter.name}s Dodge Chance:{playerCharacter.dodge}");
            Console.WriteLine($"{playerCharacter.name}s Starter Weapon:{playerCharacter.currentWeapon.name}");
            Console.WriteLine($"{playerCharacter.name}s Starter Weapon Damage:{playerCharacter.currentWeapon.minDamage}-{playerCharacter.currentWeapon.maxDamage}");
            Console.WriteLine("");
            Console.WriteLine("Do you want to choose another character(yes/no)");
            Console.WriteLine("Writing something else than the options will result as a no");
            string chooseAnotherCharacter = Console.ReadLine().ToLower();
            if(chooseAnotherCharacter == "yes")
            {
                hasChosen = false;
                Console.Clear();
            }
            else
            {
                hasChosen = true;
                Console.Clear();
            }
        }
    }
    public void PossibleEnemies()
    {
        Meatball_Fish meatballFish = new();
        Pneumonoultramicroscopicsilicovolcanoconiosis_Destroyer pneumonoultramicroscopicsilicovolcanoconiosisDestroyer = new();
        The_Emmy_Awards theEmmyAwards = new();
        if(levelNumber == 1)
        {
            currentPossibleEnemies.AddRange(new List<Enemy> {meatballFish, pneumonoultramicroscopicsilicovolcanoconiosisDestroyer, theEmmyAwards});
        }

    }
}
