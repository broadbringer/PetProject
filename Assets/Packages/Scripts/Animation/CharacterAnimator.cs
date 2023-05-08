using UnityEngine;

namespace Packages.Scripts.Animation
{
    public class CharacterAnimator : MonoBehaviour
    {
        public readonly int Idle00 = Animator.StringToHash("idle00");
        public readonly int Idle01 = Animator.StringToHash("idle01");
        public readonly int Idle02 = Animator.StringToHash("idle02");

        public readonly int Attack00 = Animator.StringToHash("attack00");
        public readonly int Attack01 = Animator.StringToHash("attack01");
        public readonly int Attack02 = Animator.StringToHash("attack02");

        public readonly int Walk01 = Animator.StringToHash("walk01");
        public readonly int Run00 = Animator.StringToHash("run00");
        public readonly int Jump00 = Animator.StringToHash("jump01");

        public readonly int Hit00 = Animator.StringToHash("hit00");
        public readonly int Hit01 = Animator.StringToHash("hit01");

        public readonly int Speed = Animator.StringToHash("Speed");
        public readonly int IsMoving = Animator.StringToHash("IsMoving");
        
        
        public Animator Animator;

        public void PlayIdle() =>
            Animator.Play(Idle02);

        public void PlayMove(float startSpeed = .1f)
        {
            Animator.SetBool(IsMoving, true);
            SetMovingState(startSpeed);
        }

        public void StopMove()
        {
            Animator.SetBool(IsMoving, false);
            SetMovingState(0);
        }

        public void SetMovingState(float @as) =>
            Animator.SetFloat(Speed, @as);
    }
}