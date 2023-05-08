using Packages.Scripts.Animation;
using Packages.Scripts.Components.InputData;
using UnityEngine;
using Zenject;

namespace Packages.Scripts.Components.Character
{
    public class UserInputForAnimation : MonoBehaviour
    {
        public CharacterAnimator CharacterAnimator;

        private IInputHardware inputHardware;

        [Inject]
        private void Construct(IInputHardware inputHardware)
        {
            this.inputHardware = inputHardware;
        }

        private void Update()
        {
            if (inputHardware.IsAnyMoveKeyDown)
                CharacterAnimator.PlayMove();
            else
                CharacterAnimator.StopMove();

        }
    }
}