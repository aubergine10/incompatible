﻿using System.Collections.Generic;
using ColossalFramework.Plugins;

namespace Incompatible.Replacements.Scripts
{
    class Limits : ReplacementBase, IReplacement
    {
        protected new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 1643902284, 1 } // Watch It!
        };

        protected new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Includes a fast and updated limits screen which lists lots of limits." }
        };

        protected new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 494094728, 1 }, // Show limits
            { 531738447, 1 }, // Show more limits
        };

        public override void OnAfterSubscribe(PluginManager.PluginInfo plugin)
        {
            base.OnAfterSubscribe(plugin);

            // todo: enable limits display
        }
    }
}