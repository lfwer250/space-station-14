﻿using Content.Shared.MachineLinking;
using Robust.Shared.GameObjects;

namespace Content.Server.MachineLinking.Components
{
    [RegisterComponent]
    public class TwoWayLeverComponent : Component
    {
        public TwoWayLeverSignal State;

        public bool NextSignalLeft;
    }
}
