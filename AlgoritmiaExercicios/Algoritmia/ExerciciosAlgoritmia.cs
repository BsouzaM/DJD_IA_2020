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
            Console.WriteLine($"You have {0} lives, use them wisely", lives);
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

            Console.WriteLine($"Nickname: {0}\n Level: {1}\n Race: {2}\n Gender: {3}\n Faction: {4}\n Class: {5}", nickname, level, race, gender, faction, theClass);
        }

        public void Frostmourne()
        {
            
        }
    }
}
