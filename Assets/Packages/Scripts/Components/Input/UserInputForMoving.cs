using System;
using Packages.Scripts.Characters;
using UnityEngine;

namespace Packages.Scripts.Components.Input
{
    public class UserInputForMoving : MonoBehaviour
    {
        public GameCharacter Character;

        private void Update()
        {
            var verticalInputAxis = UnityEngine.Input.GetAxisRaw("Vertical");
            var horizontalInputAxis = UnityEngine.Input.GetAxisRaw("Horizontal");

            var moveDirection = new Vector3(horizontalInputAxis, 0, verticalInputAxis);
            
            Character.Move(moveDirection, Character.Speed);
        }
    }
}