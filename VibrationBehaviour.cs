using JumpKing.API;
using JumpKing.BodyCompBehaviours;
using JumpKing.Player;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace JumpKing_GamepadVibration
{
    public class VibrationBehaviour : IBodyCompBehaviour
    {
        private bool isLanded = false;

        public bool ExecuteBehaviour(BehaviourContext behaviourContext)
        {
            BodyComp bodyComp = behaviourContext.BodyComp;

            if (bodyComp.IsOnGround)
            {
                if (isLanded)
                {
                    GamePad.SetVibration(PlayerIndex.One, 0.5f, 0.5f);
                    isLanded = false;
                }
                else
                {
                    GamePad.SetVibration(PlayerIndex.One, 0f, 0f);
                }
            }
            else
            {
                isLanded = true;
                GamePad.SetVibration(PlayerIndex.One, 0f, 0f);
            }

            return true;
        }
    }
}
