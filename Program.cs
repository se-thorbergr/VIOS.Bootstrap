// Program.cs — VIOS.Bootstrap (mdk2pbscript)
// Minimal PB driver; safe no-op. Packager will deploy to IngameScripts/local on build.
using System;
using Sandbox.ModAPI.Ingame;
using VRage.Game;

namespace IngameScript
{
    public partial class Program : MyGridProgram
    {
        public Program()
        {
            // Minimal: run rarely to avoid CPU usage until real code arrives.
            Runtime.UpdateFrequency = UpdateFrequency.Update100;
            Echo("VIOS.Bootstrap: ready");
        }

        public void Save()
        {
            // No state yet.
        }

        public void Main(string argument, UpdateType updateSource)
        {
            // No-op tick; keep try/catch to be PB-safe.
            try
            {
                // Placeholder
            }
            catch (Exception ex)
            {
                Echo("VIOS ERROR: " + ex.Message);
            }
        }
    }
}
