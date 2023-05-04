using System;
using System.Collections;
using UnityEngine;

namespace Packages.Scripts.Animation
{
    public class CharacterAnimator : MonoBehaviour
    {
        public int Idle00 = Animator.StringToHash("idle00");
        public int Idle01 = Animator.StringToHash("idle01");
        public int Idle02 = Animator.StringToHash("idle02");
        
        public int Attack00 = Animator.StringToHash("attack00");
        public int Attack01 = Animator.StringToHash("attack01");
        public int Attack02 = Animator.StringToHash("attack02");
        
        public int Walk01 = Animator.StringToHash("walk01");
        public int Run00 = Animator.StringToHash("run00");
        public int Jump00 = Animator.StringToHash("jump01");
        
        public int Hit00 = Animator.StringToHash("hit00");
        public int Hit01 = Animator.StringToHash("hit01");

        public Animator Animator;

        private IEnumerator Start()
        {
            Animator.Play(Idle02);

            yield return new WaitForSeconds(5);
            Animator.Play(Run00);

            yield return new WaitForSeconds(5);
            Animator.Play(Jump00);

            yield return new WaitForSeconds(5);
            Animator.Play(Hit00);

            yield return new WaitForSeconds(5);
        }
    }
}