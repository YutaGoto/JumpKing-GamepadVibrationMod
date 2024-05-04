using JumpKing.PauseMenu.BT.Actions;

namespace JumpKing_GamepadVibration
{
    public class NodeToggleEnabled: ITextToggle
    {
        public NodeToggleEnabled() : base(ModEntry.Preferences.IsEnabled) { }

        protected override string GetName() => "Enable";

        protected override void OnToggle() => ModEntry.Preferences.IsEnabled = toggle;
    }
}
