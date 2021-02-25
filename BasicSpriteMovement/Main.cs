﻿using System;

namespace BasicSpriteMovement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (var game = new SpriteMovementGame())
            {
                game.Run();
            }
        }
    }

}


