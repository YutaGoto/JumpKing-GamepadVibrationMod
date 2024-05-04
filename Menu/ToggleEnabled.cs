using JumpKing.PauseMenu.BT.Actions;
using JumpKing_GamepadVibration.Model;

namespace JumpKing_GamepadVibration
{
    public class ToggleEnabled: ITextToggle
    {
        public ToggleEnabled() : base(Preference.Preferences.IsEnabled) { }

        protected override string GetName() => "Enable";

        protected override void OnToggle() => Preference.Preferences.IsEnabled = toggle;
    }
}
