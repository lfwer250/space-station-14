using System;
using Content.Shared.Chemistry.Reagent;
using Content.Shared.FixedPoint;
using Robust.Shared.GameObjects;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Chemistry.Components
{
    /// <summary>
    /// Shared class for injectors & syringes
    /// </summary>
    [NetworkedComponent()]
    public class SharedInjectorComponent : Component
    {
        /// <summary>
        /// Component data used for net updates. Used by client for item status ui
        /// </summary>
        [Serializable, NetSerializable]
        protected sealed class InjectorComponentState : ComponentState
        {
            public FixedPoint2 CurrentVolume { get; }
            public FixedPoint2 TotalVolume { get; }
            public InjectorToggleMode CurrentMode { get; }

            public InjectorComponentState(FixedPoint2 currentVolume, FixedPoint2 totalVolume, InjectorToggleMode currentMode)
            {
                CurrentVolume = currentVolume;
                TotalVolume = totalVolume;
                CurrentMode = currentMode;
            }
        }

        public enum InjectorToggleMode
        {
            Inject,
            Draw
        }
    }
}
