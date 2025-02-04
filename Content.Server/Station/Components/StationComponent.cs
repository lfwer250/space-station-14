using Content.Shared.Station;
using Robust.Shared.Analyzers;
using Robust.Shared.GameObjects;

namespace Content.Server.Station;

[RegisterComponent, Friend(typeof(StationSystem))]
public class StationComponent : Component
{
    public StationId Station = StationId.Invalid;
}
