# NexusMods.Games.Fallout4

This library plugs into **NexusMods.App** and unlocks full Fallout 4 support.  
It follows the exact pattern of the existing [`NexusMods.Games.StardewValley`](https://github.com/Nexus-Mods/NexusMods.App/tree/main/src/NexusMods.Games.StardewValley) project.

## How to add it to the solution

1. Copy the `NexusMods.Games.Fallout4` folder into `src/`.
2. Open **NexusMods.App.sln** and include the new **.csproj** (right‑click _Solution_ → _Add_ → _Existing Project…_).
3. Build. The DI scanner in the App will pick up `Fallout4Game` automatically on launch.

Generated automatically: 2025-06-26T07:06:07.937515 UTC
