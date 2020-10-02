using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Algoritmia
{
    class ExerciciosAlgoritmia
    {
        public void LetTheGamesBegin()
        {
            Console.WriteLine("Game Started");
            Console.WriteLine("Game Playing");
            Console.WriteLine("Game Over");
        }

        public void Noob()
        {
            string player = "#Fiinz";
            Console.WriteLine($"You're such a Noob {player}! It's always good to have newbies around here!");
        }

        public void EasyPeasy()
        {
            int lives = 3;
            Console.WriteLine($"You have {lives} lives, use them wisely");
        }

        public void ForAzeroth()
        {
            string nickname, race, faction, theClass;
            int level;
            char gender;

            nickname = "Player";
            race = "Gnome";
            faction = "Horde";
            theClass = "Mage";
            level = 60;
            gender = 'm';

            Console.WriteLine($"Nickname: {nickname}\n " +
                $"Level: {level}\n " +
                $"Race: {race}\n " +
                $"Gender: {gender}\n " +
                $"Faction: {faction}\n " +
                $"Class: {theClass}");
        }

        public void Frostmourne()
        {
            string name, rarity, description, targetClass;
            bool isTwoHand = true;
            int damage = 35000;
            name = "Frostmourne";
            rarity = "Legendary";
            description = "Hail to the king, baby!";
            targetClass = "Death Knight";

            Console.WriteLine($"Weapon Name: {name}\n " +
                $"Rarity: {rarity}\n " +
                $"Description: {description}\n " +
                $"Target Class: {targetClass}\n " +
                $"Is this weapon Two-Hand? {isTwoHand}\n " +
                $"Damage: {damage}");
        }

        public void GeeGee()
        {
            int player = 100; 
            int fatalBlow = player;

            Console.WriteLine($"Player Health: {player}");
            Console.WriteLine("A wild monster appeared!");
            Console.WriteLine("As you try to attack the monster, you got stun for 30 seconds!");
            player = player - fatalBlow;
            Console.WriteLine($"Your player got a Face Slap! HP: {0}", player);
            Console.WriteLine($"You are dead!");
        }
    }
}
