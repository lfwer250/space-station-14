﻿using System;
using System.Text.RegularExpressions;
using Robust.Shared.GameObjects;
using Robust.Shared.Serialization;

namespace Content.Shared.Disposal.Components
{
    public class SharedDisposalRouterComponent : Component
    {
        public static readonly Regex TagRegex = new("^[a-zA-Z0-9, ]*$", RegexOptions.Compiled);

        [Serializable, NetSerializable]
        public class DisposalRouterUserInterfaceState : BoundUserInterfaceState
        {
            public readonly string Tags;

            public DisposalRouterUserInterfaceState(string tags)
            {
                Tags = tags;
            }
        }

        [Serializable, NetSerializable]
        public class UiActionMessage : BoundUserInterfaceMessage
        {
            public readonly UiAction Action;
            public readonly string Tags = "";

            public UiActionMessage(UiAction action, string tags)
            {
                Action = action;

                if (Action == UiAction.Ok)
                {
                    Tags = tags.Substring(0, Math.Min(tags.Length, 150));
                }
            }
        }

        [Serializable, NetSerializable]
        public enum UiAction
        {
            Ok
        }

        [Serializable, NetSerializable]
        public enum DisposalRouterUiKey
        {
            Key
        }
    }
}
