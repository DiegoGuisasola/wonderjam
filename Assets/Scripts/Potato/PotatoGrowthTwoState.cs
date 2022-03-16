using UnityEngine;

namespace Potato
{
    public class PotatoGrowthTwoState : PotatoBaseState
    {
        private float changeStateCountdown = 4.0f;

        public override void EnterState(PotatoStateManager carrot)
        {
            Animator animator = carrot.GetComponent<Animator>();
            animator.Play("GrowthTwo");
        }

        public override void UpdateState(PotatoStateManager carrot)
        {
            if (changeStateCountdown >= 0)
            {
                changeStateCountdown -= Time.deltaTime;
            }
            else
            {
                carrot.SwitchState(carrot.CompleteState);
                changeStateCountdown = 4.0f;
            }
        }
    }
}