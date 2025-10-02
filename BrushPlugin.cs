using System;
using System.Collections.Generic;
using System.Drawing;

namespace BrushPluginExample
{
    public static class BrushPlugin
    {
        public static void DemoListBrushes()
        {
            var brushes = BrushLoader.LoadAllEmbeddedBrushes();
            Console.WriteLine($"Loaded {brushes.Count} embedded brush images:");
            foreach (var kv in brushes)
            {
                Console.WriteLine($" - {kv.Key}  ({kv.Value.Width}x{kv.Value.Height})");
            }
        }
    }
}
