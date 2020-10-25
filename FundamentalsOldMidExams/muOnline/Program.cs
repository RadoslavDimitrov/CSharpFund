using System;
using System.Collections.Generic;
using System.Linq;

namespace muOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            byte health = 100;
            int bitcoins = 0;

            List<string> rooms = Console.ReadLine().Split(new char[] { '|', ' ' }).ToList();
            bool isVictory = true;
            for (int i = 0; i < rooms.Count; i+=2)
            {
                //monsters
                int attackOrHealth = int.Parse(rooms[i + 1]);
                if (rooms[i] == "potion")
                {
                    //byte currPotion = byte.Parse(rooms[i + 1]);
                    if(health + attackOrHealth > 100)
                    {
                        attackOrHealth = (100 - health);
                        Console.WriteLine($"You healed for {attackOrHealth} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {attackOrHealth} hp.");
                    }
                    health = (byte)(health + attackOrHealth);
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (rooms[i] == "chest")
                {
                    //int currCoins = int.Parse(rooms[i + 1]);
                    bitcoins += attackOrHealth;
                    Console.WriteLine($"You found {attackOrHealth} bitcoins.");
                }
                else 
                {
                    string currMonster = rooms[i];
                    //byte monsterAttack = byte.Parse(rooms[i + 1]);
                    if(health - attackOrHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {currMonster}.");
                        Console.WriteLine($"Best room: {(i + 2) / 2}");
                        isVictory = false;
                        break;
                    }
                    else
                    {
                        health = (byte)(health - attackOrHealth);
                        Console.WriteLine($"You slayed {currMonster}.");
                    }
                }
            }

            if (isVictory)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
