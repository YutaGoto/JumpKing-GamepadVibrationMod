using JumpKing.API;
using JumpKing.BodyCompBehaviours;
using JumpKing.MiscEntities.WorldItems;
using JumpKing.MiscEntities.WorldItems.Inventory;
using JumpKing.Player;
using JumpKing_GamepadVibration.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace JumpKing_GamepadVibration.Behaviour
{
    public class Vibration : IBodyCompBehaviour
    {
        private const PlayerIndex PLAYER_ONE = PlayerIndex.One;
        private bool isLanded = false;
        private bool setKnocked = false;

        public bool ExecuteBehaviour(BehaviourContext behaviourContext)
        {
            BodyComp bodyComp = behaviourContext.BodyComp;

            if (!Preference.Preferences.IsEnabled) return true;

            if (Preference.Preferences.IsLanded) LandedVibration(bodyComp);
            if (Preference.Preferences.IsKnocked) KnockedVibration(behaviourContext);

            return true;
        }

        private void LandedVibration(BodyComp bodyComp)
        {
            float power = 0f;
            if (bodyComp.IsOnGround)
            {
                if (isLanded)
                {
                    power = InventoryManager.HasItemEnabled(Items.GiantBoots) && Preference.Preferences.GiantBootsPower ? 1.0f : 0.3f;
                    isLanded = false;
                }
            }
            else
            {
                isLanded = true;
            }

            SetVibration(power, power);
        }

        private void KnockedVibration(BehaviourContext behaviourContext)
        {
            if (behaviourContext.ContainsKey("PlayBumpSFX"))
            {
                setKnocked = true;
                SetVibration(0f, 0f);
            }
            else
            {
                if (setKnocked)
                {
                    SetVibration(0.3f, 0.3f);
                    setKnocked = false;

                }
                else
                {
                    SetVibration(0f, 0f);
                }
            }
        }

        private void SetVibration(float leftMotor, float rightMotor)
        {
            GamePad.SetVibration(PLAYER_ONE, leftMotor, rightMotor);
        }
    }
}
