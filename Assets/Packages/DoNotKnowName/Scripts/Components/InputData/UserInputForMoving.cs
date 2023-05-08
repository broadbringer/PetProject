using System;
using Packages.Scripts.Characters;
using UnityEngine;
using Zenject;

namespace Packages.Scripts.Components.InputData
{
    public class UserInputForMoving : MonoBehaviour
    {
        public GameCharacter Character;
        
        private IInputHardware inputHardware;
        
        [Inject]
        private void Construct(IInputHardware inputHardware)
        {
            this.inputHardware = inputHardware;
        }

        private void Update()
        {
            var verticalInputAxis = inputHardware.VerticalAxis;
            var horizontalInputAxis = inputHardware.HorizontalAxis;

            var moveDirection = new Vector3(horizontalInputAxis, 0, verticalInputAxis);
            
            Character.Move(moveDirection, Character.Speed);
        }
    }
}