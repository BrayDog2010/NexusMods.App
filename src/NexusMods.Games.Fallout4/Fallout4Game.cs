using NexusMods.App.Core.Games.Base;
using NexusMods.App.Core.Games.Definitions;
using NexusMods.App.Core.LoadOrder.Bethesda;
using NexusMods.Contracts.Games;

namespace NexusMods.Games.Fallout4;

/// <summary>
/// Game plugin providing Fallout 4 support for the Nexus Mods App.
/// Patterned after <c>StardewValleyGame</c> in <c>NexusMods.Games.StardewValley</c>.
/// </summary>
public sealed class Fallout4Game : BethesdaGame
{
    /// <inheritdoc />
    public override GameId Id => new("fallout4");

    /// <inheritdoc />
    public override string NexusModsDomain => "fallout4";

    /// <inheritdoc />
    public override string FriendlyName => "Fallout 4";

    /// <inheritdoc />
    public override GameCategory Category => GameCategory.BethesdaGame;

    /// <inheritdoc />
    public override IReadOnlyCollection<StoreDefinition> StoreDefinitions { get; } =
    [
        // Steam
        new SteamDefinition(appId: 377160, executable: "Fallout4.exe"),

        // GOG Galaxy
        new GogDefinition(gameId: 1440164303, executable: "Fallout4.exe"),

        // Xbox Game Pass for PC / Microsoft Store
        new XboxDefinition(
            packageFamilyName: "BethesdaSoftworks.FALLOUT4_3275kfvn8vcwc",
            executable: "Fallout4.exe")
    ];

    protected override string DataFolderName => "Data";

    protected override string GetExecutableRelativePath() => "Fallout4.exe";

    public override ILoadOrderProvider CreateLoadOrderProvider(ILoadoutContext ctx) =>
        new BethesdaLoadOrderProvider(ctx, "plugins.txt");
}
