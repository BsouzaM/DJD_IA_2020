using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO.Pipes;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Algoritmia
{
    public class ExerciciosAlgoritmia
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
            Console.WriteLine("You're such a Noob {0}! It's always good to have newbies around here!", player);
        }

        public void EasyPeasy()
        {
            int lives = 3;
            Console.WriteLine("You have {0} lives, use them wisely", lives);
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
            gender = 'M';

            Console.WriteLine("Nickname: {0}\n " +
                "Level: {1}\n " +
                "Race: {2}\n " +
                "Gender: {3}\n " +
                "Faction: {4}\n " +
                "Class: {5}", nickname, level, race, gender, faction, theClass);
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

            Console.WriteLine("Weapon Name: {0}\n " +
                "Rarity: {1}\n " +
                "Description: {2}\n " +
                "Target Class: {3}\n " +
                "Is this weapon Two-Hand? {4}\n " +
                "Damage: {5}", name, rarity, description, targetClass, isTwoHand, damage);
        }

        public void GeeGee()
        {
            int player = 100;
            int fatalBlow = player;

            Console.WriteLine("Player Health: {0}", player);
            Console.WriteLine("A wild monster appeared!");
            Console.WriteLine("As you try to attack the monster, you got stun for 30 seconds!");
            player = player - fatalBlow;
            Console.WriteLine("Your player got a Face Slap! HP: {0}", player);
            Console.WriteLine("You are dead!");
        }
        public void LuckyBastard()
        {
            Random r = new Random();
            int hp = 100;

            int dmg = r.Next(1, hp - 3);
            Console.WriteLine("Damage: {0}", dmg);
            hp = hp - dmg;
            Console.WriteLine("HP: {0}", hp);

            dmg = r.Next(1, hp - 2);
            Console.WriteLine("Damage: {0}", dmg);
            hp = hp - dmg;
            Console.WriteLine("HP: {0}", hp);

            dmg = hp - 1;
            Console.WriteLine("Damage: {0}", dmg);
            hp = hp - dmg;
            Console.WriteLine("HP: {0}", hp);

            Console.WriteLine("Lucky Bastard!");
        }
        public void Vegito()
        {
            Random r = new Random();
            int cAverageAtk, cAverageDef, cAverageInt;

            cAverageAtk = (r.Next(1, 100) + r.Next(1, 351)) / 2;
            cAverageDef = (r.Next(1, 100) + r.Next(1, 156)) / 2;
            cAverageInt = (r.Next(1, 1001) + r.Next(1, 851)) / 2;

            Console.WriteLine("Average of Attack: {0}\n" +
                "Average of Defense: {1}\n" +
                "Average of Intellect: {2}", cAverageAtk, cAverageDef, cAverageInt);
        }
        public void LetsGetPumped()
        {
            Random r = new Random();
            float attackPower = r.Next(1, 2000);
            float powerUp = 1.5f; // 50% de X == 1.5

            attackPower = attackPower * powerUp; // Adiciona 50%
            Console.WriteLine("Your attack power using the Power UP is: {0}", attackPower);

            attackPower = attackPower / powerUp; // Remove 50%
            Console.WriteLine("Your attack power without using the Power UP is: {0}", attackPower);
        }
        public void Roll()
        {
            Random r = new Random();
            int p1 = r.Next(1, 7);
            int p2 = r.Next(1, 7);
            Console.WriteLine("Roll Player 1: {0}" +
                "\nRoll Player 2: {1}", p1, p2);

            if (p1 > p2) Console.WriteLine("Maior Roll é o P1: {0}", p1);
            else Console.WriteLine("Maior Roll é o P2: {0}", p2);
        }
        public void LostintheMap()
        // 0 == canto superior esquerdo
        // BUGGED
        {
            Random r = new Random();
            int xp1 = r.Next(1, 501);
            Console.WriteLine("Player 1 - X Position: {0}", xp1);

            int yp1 = r.Next(1, 501);
            Console.WriteLine("Player 1 - Y Position: {0}", yp1);

            if (xp1 > 250)
            {
                if (yp1 > 250)
                    Console.WriteLine("The position of the character is on the Top - Right side of the map");
                else if (yp1 < 250)
                    Console.WriteLine("The position of the character is on the Bottom - Right side of the map");
            }

            else if (xp1 < 250)
            {
                if (yp1 < 250)
                    Console.WriteLine("The position of the character is on the Bottom - Left side of the map");
                else if (yp1 > 250)
                    Console.WriteLine("The position of the character is on the Top - Left side of the map");
            }

            Console.WriteLine();
        }
        public void TimeOver()
        {
            for (int i = 99; i >= 0; i -= 1)
            {
                Console.WriteLine("{0}", i);
                if (i == 0)
                {
                    Console.WriteLine("Game Over");
                }
            }
        }

        public void Even()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void KeepRandomizing()
        {
            Random r = new Random();
            int n = r.Next(0, 100);

            for (int i = 0; i < n; i++)
            {
                int coordX = r.Next(0, 100);
                int coordY = r.Next(0, 100);
                Console.WriteLine("Coordenada X: " + coordX);
                Console.WriteLine("Coordenada Y: " + coordY);
            }
        }

        public void BetweenWalls()
        {
            Random r = new Random();

            int a = r.Next(1);
            int b = r.Next(a, 100);

            for (int i = a; i <= b; i++)
            {
                Console.WriteLine("Os valores entre {0} e {1} são: {2}", a, b, i);
            }
        }

        // a partir daqui começou a dar ré

        public void LetsMove()
        {
            // Moves a character's position frame by frame - wtf? Frame by frame significa runtime by runtime? Ou cada vez q eu pressiono um botão? Precisa ser explicado melhor.
            // from the position (0, 0) -- O playerX e playerY começam a 0, 0;
            // to a target random position in a map with 1000px x 1000px - Ao pressionar W, A, S ou D o player vai para uma posição aleatória

            Random r = new Random();
            TileManagement t = new TileManagement();

            int mapValueX, mapValueY;

            // Caso haja apenas um valor para X e Y:
            mapValueX = 1000;
            mapValueY = mapValueX;

            // O player começa em 0, 0 :D
            int playerX = 0;
            int playerY = 0;

            int destX = r.Next(0, mapValueX + 1);
            int destY = r.Next(-10, mapValueY + 1);

            Console.Clear();
            Console.WriteLine("O mapa será de {0} por {1}.", mapValueX, mapValueY);
            Console.WriteLine("O destino será {0} em X e {1} em Y", destX, destY);
            Console.WriteLine();

            do
            {
                if (playerX < destX)
                {
                    playerX++;
                    Console.WriteLine("Player moveu +1 em X.\nPosição X: {0}\nPosição Y: {1}", playerX, playerY);
                    Console.WriteLine();
                }
                else if (playerX > destX)
                {
                    playerX--;
                    Console.WriteLine("Player moveu -1 em X.\nPosição X: {0}\nPosição Y: {1}", playerX, playerY);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Chegou no destino em X.\nPosição X: {0}\nPosição Y: {1}", playerX, playerY);
                    Console.WriteLine();
                }
                if (playerY < destY)
                {
                    playerY++;
                    Console.WriteLine("Player moveu +1 em Y.\nPosição X: {0}\nPosição Y: {1}", playerX, playerY);
                    Console.WriteLine();
                }
                else if (playerY > destY)
                {
                    playerY--;
                    Console.WriteLine("Player moveu -1 em Y.\nPosição X: {0}\nPosição Y: {1}", playerX, playerY);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Chegou no destino em Y.\nPosição X: {0}\nPosição Y: {1}", playerX, playerY);
                    Console.WriteLine();
                }
            } while (playerX != destX && playerY != destY);
            Console.ReadLine();
        }
        public void OnePath()
        {
            // Não consegui resolver... :c
        }

        public void SecretNumber()
        {
            Random r = new Random();
            int secretNumber = r.Next(0, 101);
            bool playerGuess = true;
            while (playerGuess)
            {
                Console.WriteLine("What is the secret number?");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("You found the secret number! Congratulations!");
                    break;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("The secret number is greater than your guess.");
                }
                else
                {
                    Console.WriteLine("The secret number is smaller than your guess.");
                }
            }
            Console.WriteLine("");
        }

        public void ShakeItBaby()
        {
            Random r = new Random();
            bool flag = true;

            Console.WriteLine("Quantos bursts a arma terá?");
            int bursts = Convert.ToInt32(Console.ReadLine());

            while (flag)
            {
                for (int i = 0; i < bursts; i++)
                {
                    if (i == 10)
                    {
                        Console.WriteLine("Reload!");
                        Thread.Sleep(2000);
                    }
                    else if (i > 10 && i == 20)
                    {
                        Console.WriteLine("Reload!");
                        Thread.Sleep(2000);
                    }
                    else if (i > 20 && i == 30)
                    {
                        Console.WriteLine("Final Reload!");
                        Thread.Sleep(2000);
                        flag = false;
                    }
                    else
                        flag = false;

                    Console.WriteLine("Burst!");
                }
            }
            Console.WriteLine("");
        }
        public void AliAlwaysWins()
        {
            Random r = new Random();

            int hp1 = 100;
            int hp2 = 100;

            int atkPlayer1, atkPlayer2;
            int decisionP1, decisionP2;  // 0 - N faz nada, 1 - Attack, 2 - Block, 3 é exclusivo

            // condition ? consequent : alternative
            // is this condition true ? yes : no
            // But I'm not using because it makes things hard

            bool flag = true; // useful variable that doesn't make me feel confused. thanks teacher

            while (flag)
            {
                atkPlayer1 = r.Next(0, 11);
                atkPlayer2 = r.Next(0, 11);

                decisionP1 = r.Next(0, 3);
                decisionP2 = r.Next(0, 3);

                Console.WriteLine("");
                Console.WriteLine("Decisão do Player 1: {0}", decisionP1);
                Console.WriteLine("Decisão do Player 2: {0}", decisionP2);
                ConsoleKeyInfo round = Console.ReadKey();

                if (decisionP1 == 1 && decisionP2 != 2) // Se a decisão do P1 for atacar e a do P2 não for defender
                {
                    hp2 -= atkPlayer1; // P2 toma dano
                    Console.WriteLine("");
                    Console.WriteLine("Player 1 atacou o Player 2!\nHP Player 2: {0}", hp2);
                }
                else if (decisionP1 == 2 && decisionP2 != 1) // Se a decisão do P1 for defender e a do P1 não for atacar
                {
                    Console.WriteLine("");
                    Console.WriteLine("Player 1 deu Block!");
                }
                else
                { // Se não for nenhuma das duas acima
                    Console.WriteLine("");
                    Console.WriteLine("Player 1 não fez nada porque é preguiçoso");
                }

                if (decisionP2 == 1 && decisionP1 != 2) // Se a decisão do P2 for atacar e a do P1 não for defender
                {
                    hp1 -= atkPlayer2; // P1 toma dano
                    Console.WriteLine("");
                    Console.WriteLine("Player 2 atacou o Player 1!\nHP Player 1: {0}", hp1);
                }
                else if (decisionP2 == 2 && decisionP1 != 1) // Se a decisão do P2 for defender e a do P1 não for atacar
                {
                    Console.WriteLine("");
                    Console.WriteLine("Player 2 deu Block!");
                }
                else
                { // Se não for nenhuma das duas acima
                    Console.WriteLine("");
                    Console.WriteLine("Player 2 não fez nada porque é preguiçoso");
                }

                // já tem muito if pra eu continuar a fazer esse exercício
                // Não vale a pena gastar mais tempo assim se eu não consegui aprender a usar o operador "?"

                if (hp1 <= 0 || hp2 <= 0)
                {
                    flag = false;
                }
            }
        }
        public void Filli_n() // ler 20 notas e introduzir num array e descobrir a última nota positiva
        {
            Random r = new Random();
            int[] numeros = new int[100];

            for (int i = numeros.Length - 1; i > 0; i--)
                if (numeros[i] >= 10)
                {
                    Console.WriteLine("Última nota positiva: {0}", numeros[i]);
                }


            for (int i = 0; i < 50; i++)
            {
                numeros[i] = i + 1;
                if (i == 5)
                {
                    numeros[i + 5] = i * 10;
                }
            }
            // Por algum motivo o primeiro for loop não aparece no console.
            Console.ReadKey();
        }

        public void Raid()
        {
            Random r = new Random();
            string[] characters = { "w", "w", "p", "m", "b", "r" };

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}", characters[i]);
                r.Next(0, 20);
            }
        }
        public void Leaderboard()
        {
            Random r = new Random();
            int num1 = r.Next(0, 1000);
            int num2 = r.Next(0, 1000);
            int num3 = r.Next(0, 1000);

            int m1 = num1;
            int m2 = num2;
            int m3 = num3;

            for (int i = 0; i < 20; i++)
            {
                if (num3 > num2 || num3 > num1)
                {
                    m1 = num3;
                    Console.WriteLine("{0}", i);
                    if (num2 > num3 || num2 > num1)
                    {
                        m1 = num2;
                        Console.WriteLine("{0}", i);
                        if (num1 > num2 || num1 > num3)
                        {
                            m1 = num1;
                            Console.WriteLine("{0}", i);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
        public void CheckLeaders()
        {
            Random r = new Random();
            int[] players = new int[r.Next(0, 151)];
            int numLeader = 0;

            for (int i = 0; i < players.Length; i++)
            {
                for (int j = i + 1; j < players.Length; j++)
                {
                    // se o número gerado no fim é maior que os outros, break;
                    // se numa posição aleatória um número gerado é maior que o anterior, pula o check desse numero
                    // se o primeiro número é maior que o segundo, guarda esse valor em uma variavel
                    // quando houver um último valor, break;
                }
            }
        }
        public void CommonGrounds()
        {
            Random r = new Random();
            int num = 1;

            int p1 = 10;
            int p2 = 10;

            int deck1;
            int deck2;

            // Check entre cartas
            for (int i = 0; i < 52; i++)
            {
                deck1 = r.Next(1, 53);
                deck2 = r.Next(1, 53);

                if (deck1 == deck2)
                {
                    Console.WriteLine("Common card between decks: {0}", deck1);
                    Console.WriteLine("Amount of cards in common between decks: {0}", num++);
                }
            }
        }
        public void SortArray()
        {
            int[] arrayTeste = { 1, 6, 26, 35, 11, 0 };

            for (int i = 0; i < arrayTeste.Length; i++)
            {
                for (int j = i + 1; j < 1; j++)
                {
                    if (arrayTeste[i] > arrayTeste[j])
                    {
                        int temp = arrayTeste[j];
                        arrayTeste[j] = arrayTeste[i];
                        arrayTeste[i] = temp;
                    }

                    Console.WriteLine(arrayTeste[i]);
                }
            }
            Console.ReadLine();
            //  
        }
    }
}

