using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Text;

namespace Algoritmia
{
    public class TileManagement
    {
        public void InitTiles(int mapX, int mapY)
        {
            // Array Multi-dimensional com os valores mapX e mapY, que são os valores preenchidos por mapValueX e mapValueY em ExerciciosAlgoritmia.cs         
            // Para cada iteração deste for loop, preencha todas as rows e cols.
            for (int rows = 0; rows < mapX; rows++)
            { 
                for (int cols = 0; cols < mapY; cols++)
                {
                    Console.Write('X');
                }
                // Depois que é preenchido 1 cols, preenche 1 rows.
                Console.WriteLine('X');
            }
        }
    }
}

