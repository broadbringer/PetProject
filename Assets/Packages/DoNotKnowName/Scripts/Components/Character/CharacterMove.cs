
using UnityEngine;

namespace Packages.Scripts.Components.Character
{
    public class CharacterMove : MonoBehaviour
    {
        public CharacterController CharacterController;
        
        public void MoveTo(Vector3 position, float withSpeed) =>
            CharacterController.Move(position * Time.deltaTime * withSpeed);
    }
}