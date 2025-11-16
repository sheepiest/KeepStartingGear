using System.Collections.Generic;
using SPTarkov.Server.Core.Models.Spt.Mod;   // AbstractModMetadata
using Range = SemanticVersioning.Range;       // Avoids conflict with System.Range

namespace Blackhorse311.KeepStartingGear
{
    /// <summary>
    /// Static metadata for the Keep Starting Gear mod (SPT 4.0).
    /// SPT reflects over this at startup to identify and register the mod.
    /// </summary>
    public record ModMetadata : AbstractModMetadata
    {
        // Must be globally unique; also used by Forge for identification.
        public override string ModGuid { get; init; } = "com.blackhorse311.keepstartinggear";

        // Name and Author: letters and numbers only per Forge guidelines.
        public override string Name   { get; init; } = "Blackhorse311KeepStartingGear";
        public override string Author { get; init; } = "Blackhorse311";

        // Semantic version of this mod (should match .csproj <Version>).
        public override SemanticVersioning.Version Version { get; init; } =
            new SemanticVersioning.Version("2.1.1");

        // SPT version compatibility range.
        public override Range SptVersion { get; init; } = new Range("4.0.4");

        // URL for source / documentation.
        public override string? Url { get; init; } =
            "https://github.com/Blackhorse311/KeepStartingGear";

        // License string.
        public override string License { get; init; } = "MIT";

        // This mod is server-only; it does not ship client bundles.
        public override bool? IsBundleMod { get; init; } = false;

        // Optional: other mods required to be present (none for this mod).
        public override Dictionary<string, Range>? ModDependencies { get; init; } = new();

        // Optional: additional contributors.
        public override List<string>? Contributors { get; init; } = new()
        {
            "Blackhorse311"
        };

        // Optional: incompatible mods (by ModGuid or name).
        public override List<string>? Incompatibilities { get; init; } = new();
    }
}