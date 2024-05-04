using JumpKing.PauseMenu.BT.Actions;
using JumpKing_GamepadVibration.Model;

namespace JumpKing_GamepadVibration.Menu
{
    public class ToggleIsKnocked: ITextToggle
    {
        public ToggleIsKnocked() : base(Preference.Preferences.IsKnocked) { }
        protected override string GetName() => "To Knock";

        protected override void OnToggle() => Preference.Preferences.IsKnocked = toggle;

        protected override bool CanChange() => Preference.Preferences.IsEnabled;
    }
}
