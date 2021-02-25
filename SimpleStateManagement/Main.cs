﻿using System;

namespace SimpleStateManagement
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new StateManagementGame())
                game.Run();
        }
    }
}
