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
            int[,] map = new int[mapX, mapY];
            for (int rows = 0; rows < mapX; rows++)
            {
                for (int cols = 0; cols < mapY; cols++)
                {
                    Console.Write('X');
                }
                Console.WriteLine('X');
            }
        }
    }
}

