using JumpKing.Mods;
using JumpKing.PauseMenu.BT.Actions;
using JumpKing.PauseMenu;
using JumpKing.Player;
using EntityComponent;

namespace JumpKing_GamepadVibration
{
    [JumpKingMod("YutaGoto.JumpKing_GamepadVibration")]
    public static class ModEntry
    {
        public static bool isEnabled;

        [MainMenuItemSetting]
        public static ITextToggle AddToggleEnabled(object factory, GuiFormat format)
        {
            return new NodeToggleEnabled(isEnabled);
        }

        /// <summary>
        /// Called by Jump King before the level loads
        /// </summary>
        [BeforeLevelLoad]
        public static void BeforeLevelLoad(){ }

        /// <summary>
        /// Called by Jump King when the level unloads
        /// </summary>
        [OnLevelUnload]
        public static void OnLevelUnload() { }

        /// <summary>
        /// Called by Jump King when the Level Starts
        /// </summary>
        [OnLevelStart]
        public static void OnLevelStart()
        {
            if (!isEnabled) return;
            PlayerEntity player = EntityManager.instance.Find<PlayerEntity>();

            if (player != null)
            {
                player.m_body.RegisterBehaviour(new VibrationBehaviour());
            }
        }

        /// <summary>
        /// Called by Jump King when the Level Ends
        /// </summary>
        [OnLevelEnd]
        public static void OnLevelEnd() { }
    }
}
