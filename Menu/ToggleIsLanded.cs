using JumpKing.PauseMenu.BT.Actions;
using JumpKing_GamepadVibration.Model;

namespace JumpKing_GamepadVibration.Menu
{
    public class ToggleIsLanded : ITextToggle
    {
        public ToggleIsLanded() : base(Preference.Preferences.IsLanded) { }

        protected override string GetName() => "To Land";

        protected override void OnToggle() => Preference.Preferences.IsLanded = toggle;

        protected override bool CanChange() => Preference.Preferences.IsEnabled;
    }
}
