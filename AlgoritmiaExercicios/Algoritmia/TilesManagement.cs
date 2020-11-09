using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Text;

namespace Algoritmia
{
    public class TileManagement
    {
        // Um mapa em X e Y, caso for preciso para algum exercício.
        public void InitTiles(int mapX, int mapY)
        {        
            // Para cada iteração deste for loop, preencha todas as rows e cols.
            for (int rows = 0; rows < mapX; rows++)
            { 
                for (int cols = 0; cols < mapY; cols++)
                {
                    Console.Write('=');
                }
                // Depois que é preenchido 1 cols, preenche 1 rows.
                Console.WriteLine('=');
            }
        }
    }
}

