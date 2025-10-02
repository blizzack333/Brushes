using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace BrushPluginExample
{
    public static class BrushLoader
    {
        public static Dictionary<string, Bitmap> LoadAllEmbeddedBrushes()
        {
            var asm = Assembly.GetExecutingAssembly();
            var list = new Dictionary<string, Bitmap>();
            foreach (string resName in asm.GetManifestResourceNames())
            {
                if (resName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                    resName.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                    resName.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                    resName.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        using (Stream s = asm.GetManifestResourceStream(resName))
                        {
                            if (s != null)
                            {
                                var bmp = new Bitmap(s);
                                list[resName] = bmp;
                            }
                        }
                    }
                    catch { }
                }
            }
            return list;
        }
    }
}
