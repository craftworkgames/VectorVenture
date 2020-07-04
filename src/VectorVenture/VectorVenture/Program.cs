// Copyright (c) Craftwork Games. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace VectorVenture
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            using var game = new VectorVentureGame();
            game.Run();
        }
    }
}
