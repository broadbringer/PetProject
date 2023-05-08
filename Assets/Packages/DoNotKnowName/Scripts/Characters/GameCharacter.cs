using Packages.Scripts.Components.Character;
using UnityEngine;

namespace Packages.Scripts.Characters
{
    public class GameCharacter : MonoBehaviour
    {
        public CharacterMove Mover;

        public float Speed = 10;

        public void Move(Vector3 position, float withSpeed) =>
            Mover.MoveTo(position, withSpeed);

        public void Attack()
        {
        }

        public void Death()
        {
        }

        public void Jump()
        {
        }

        public void TakeDamage()
        {
        }
    }
}