﻿using System.Security.Cryptography.X509Certificates;

namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Shop
{
    public List<Item> shopInventory = new();
    public List<Item> currentShopInventory = new();
    public Shop()
    {
        Axe axe = new();
        Banana banana = new();
        Big_Ass_Shark bigAssShark = new();
        Drugs drugs = new();
        HolyChainsaw holyChainsaw = new();
        SledgeHammer sledgeHammer = new();
        Whip whip = new();
        shopInventory.AddRange(new List<Item>{axe, banana, bigAssShark, drugs, holyChainsaw, sledgeHammer, whip});
    }

    public void Shopping(Random generator, Player playerCharacter)
    {
        for(int i = 0; i < 3; i++)
        {
            int shopItems = generator.Next(0, shopInventory.Count);
            Console.WriteLine(shopItems);
            currentShopInventory.Add(shopInventory[shopItems]);
        }
        Console.WriteLine($"Choose an item or skip(write a higher number to skip)");
        for(int i = 0; i<currentShopInventory.Count; i++)
        {
            Console.WriteLine($"{i+1}. {currentShopInventory[i].name}");
        }
        int shopChoice;
        while (!int.TryParse(Console.ReadLine(), out shopChoice))
        {       
            Console.Write("You didn't provide a number you stupid dumb fuck, please try again:");
        }
        if(shopChoice > currentShopInventory.Count)
        {
            currentShopInventory.Clear();
        }
        else if(currentShopInventory[shopChoice-1] is Weapon)
        {
            playerCharacter.currentWeapon = (Weapon)currentShopInventory[shopChoice-1];
            currentShopInventory.Clear();
        }
    }
}
