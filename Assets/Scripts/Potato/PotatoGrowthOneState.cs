using UnityEngine;

namespace Potato
{
    public class PotatoGrowthOneState : PotatoBaseState
    {
        private float changeStateCountdown = 1.0f;

        public override void EnterState(PotatoStateManager carrot)
        {
            Animator animator = carrot.GetComponent<Animator>();
            animator.Play("GrowthOne");
        }

        public override void UpdateState(PotatoStateManager carrot)
        {
            if (changeStateCountdown >= 0)
            {
                changeStateCountdown -= Time.deltaTime;
            }
            else
            {
                carrot.SwitchState(carrot.GrowthTwoState);
                changeStateCountdown = 1.0f;
            }
        }
    }
}