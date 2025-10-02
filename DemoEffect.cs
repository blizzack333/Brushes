using System;
using System.Drawing;
using PaintDotNet;
using PaintDotNet.Effects;
using PaintDotNet.PropertySystem;
using PaintDotNet.Rendering;

namespace BrushPluginExample
{
    // Minimal Paint.NET Effect plugin
    public sealed class DemoEffect : Effect
    {
        public DemoEffect() : base("Brush Plugin Demo", null, "Demo", EffectFlags.None) { }

        public override EffectConfigDialog CreateConfigDialog()
        {
            return null; // no UI for this minimal demo
        }

        public override void Render(EffectConfigToken parameters, RenderArgs dstArgs, RenderArgs srcArgs, Rectangle[] rois, int startIndex, int length)
        {
            // No-op; effect exists only to appear in the Effects menu
            for (int i = startIndex; i < startIndex + length; ++i) { }
        }
    }
}
