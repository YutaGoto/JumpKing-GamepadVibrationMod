using JumpKing.PauseMenu.BT.Actions;
using JumpKing_GamepadVibration.Model;

namespace JumpKing_GamepadVibration.Menu
{
    public class ToggleGiantBootsPower: ITextToggle
    {
        public ToggleGiantBootsPower() : base(Preference.Preferences.GiantBootsPower) { }
        protected override string GetName() => "Giant Boots Power";

        protected override void OnToggle() => Preference.Preferences.GiantBootsPower = toggle;

        protected override bool CanChange() => Preference.Preferences.IsLanded;
    }
}
