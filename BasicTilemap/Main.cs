﻿using System;

namespace BasicTilemap
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new TileMapGame())
                game.Run();
        }
    }
}


