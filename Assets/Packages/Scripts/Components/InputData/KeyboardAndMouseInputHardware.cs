using UnityEngine;

namespace Packages.Scripts.Components.InputData
{
    public class KeyboardAndMouseInputHardware : IInputHardware
    {
        public float HorizontalAxis => Input.GetAxisRaw("Horizontal");
        public float VerticalAxis => Input.GetAxisRaw("Vertical");

        public bool IsAnyMoveKeyDown => HorizontalAxis != 0 || VerticalAxis != 0;

        public bool IsJumpKeyDown => Input.GetKeyDown(KeyCode.Space);

        public bool IsAttackButtonDown => Input.GetMouseButtonDown(0);
    }
}